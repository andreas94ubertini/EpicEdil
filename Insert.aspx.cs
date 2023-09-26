using EpicEdil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicEdil
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Inserisci_Click(object sender, EventArgs e)
        {
            Database.InsertDipendente(NomeBox.Text, CognomeBox.Text, IndirizzoBox.Text, CdfBox.Text, MansioneBox.Text, SposatoBox.Checked, Convert.ToInt32(FigliBox.Text));
            Response.Redirect("Default.aspx");
        }
    }
}