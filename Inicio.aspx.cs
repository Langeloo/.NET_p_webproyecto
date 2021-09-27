using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Index.loadlogin = true;
            if (Index.activesesion)
            {
                Response.Write("<script>Alert('Sesion iniciada con exito, BIENVENIDO!!!');</script>");
            }
            
        }
    }
}