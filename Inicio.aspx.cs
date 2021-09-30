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
          if(Index.Sesion == 1)
            {
                Response.Write("<script>alert('BIENVENIDO A ELEGANCE BARBER SHOP "+Index.user.getNombre1().ToUpper()+"');</script>");
                Index.Sesion = 5;
            }
          if(Index.Sesion == 2)
            {
                Response.Write("<script>alert('Cerró sesión efectivamente, te esperamos...');</script>");
                Index.Sesion = 5;
            }
        }
    }
}