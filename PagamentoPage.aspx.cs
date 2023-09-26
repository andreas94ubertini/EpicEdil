using EpicEdil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicEdil
{
    public partial class Pagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Dipendente> dipendenti = Database.getAllDipenti();
            for(int i = 0; i < dipendenti.Count; i++)
            {
                DropDownList1.Items.Insert(i, new ListItem($"{dipendenti[i].Nome} {dipendenti[i].Cognome}", Convert.ToString(dipendenti[i].IdDipendente)));
            }

        }

        protected void Inserisci_Click(object sender, EventArgs e)
        {
            Database.InsertPagamento(Convert.ToDateTime(DataBox.Text), Convert.ToDouble(ImportoBox.Text), StipendioBox.Checked, Convert.ToInt32(DropDownList1.SelectedItem.Value));
            Response.Redirect("Default.aspx");
        }
    }
}