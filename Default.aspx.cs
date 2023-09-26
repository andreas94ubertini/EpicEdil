using EpicEdil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicEdil
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Models.Pagamento> pagamenti = Database.GetAllPagamenti();
            RepeaterPagamenti.DataSource = pagamenti;
            RepeaterPagamenti.DataBind();
            List<Dipendente> dipendenti = Database.getAllDipenti();
            RepeaterDipendenti.DataSource = dipendenti;
            RepeaterDipendenti.DataBind();
            
        }
    }
}