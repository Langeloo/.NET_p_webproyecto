using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class Index : System.Web.UI.MasterPage
    {
        public static bool estadosesion= false;
        public static bool enlogin= false;
        public static char roLin;
        public static Usuario user = new Usuario();
        public static int Sesion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(estadosesion)
            {
                switch (roLin)              
                {
                    case 'a':
                        {
                            Apartar.Visible = false;
                            Admin.Visible = true;
                            VerCitas.Visible = false;
                            break;
                        }
                    case 'b':
                        {
                            Apartar.Visible = false;
                            Admin.Visible = false;
                            VerCitas.Visible = true;
                            break;
                        }
                    case 'u':
                        {
                            Apartar.HRef = "citasCliente.aspx";
                            Apartar.Visible = true;
                            Admin.Visible = false;
                            VerCitas.Visible = false;
                            break;
                        }
                    default:
                        {
                            Response.Write("<script>alert('No se sabe que tipo de usuario inicio sesión');</script>");
                            break;
                        }

                }
                
                    

                
                BtnCerrarS.Visible = true;
                BtnIniciar.Visible = false;
                
            }
            else
            {
                Apartar.HRef = "Login.aspx";
                BtnCerrarS.Visible = false;
                Admin.Visible = false;
                VerCitas.Visible = false;
            }
            if(enlogin)
            {
                VerCitas.Visible = false;
                BtnCerrarS.Visible = false;
                Admin.Visible = false;
                BtnIniciar.Visible = !enlogin;
                Index.enlogin = false;
            }
            

           
        }
    }
}