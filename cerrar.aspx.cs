using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class cerrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Index.activesesion = false;
            Response.Write("<script>Alert('TE ESPERAMOS PRONTO!!');</script>");
            //MessageBox.Show("Data inserted successfully");
            //System.Threading.Thread.Sleep(3000);
            Response.Redirect("Inicio.aspx");
        }
    }
}