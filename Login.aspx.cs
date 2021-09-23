using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            Conexion ob = new Conexion();
            try
            {
                ob.conectar();
                Response.Write("<script>alert('Se accedio a la base de datos');</script>");
            }catch(Exception eo)
            {
                Response.Write("<script>alert('No se pudo nea');</script>"+ eo.Message);
            }
           
          
            
        }
    }
}