using MySql.Data.MySqlClient;
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
        public static Boolean cloadlogin = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Index.loadlogin = cloadlogin;
        }

        protected void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            
            UsuarioCrud buscar = new UsuarioCrud();
            if (buscar.ComprobarExistencia(TextBoxCorreo.Text) || TextBoxCorreo.Text.Contains("."))
            {
                Usuario objeto = new Usuario(TextBoxCorreo.Text,TextBoxPassword.Text,"","","","","",0);

                if(buscar.ComprobarUsuario(objeto))
                {
                    Response.Write("<script>alert('BIENVENIDO A ELEGANCE BARBERSHOP');</script>");
                    Index.activesesion = true;
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    TextBoxPassword.Text ="";
                    TextBoxPassword.Focus();
                    Response.Write("<script>alert('Contraseña incorrecta, por favor vuelva a intentar');</script>");
                }

                
            }
            else
            {
                Response.Write("<script>alert('El correo no está registrado, por favor vuelva a intentar');</script>");
                TextBoxCorreo.Text = "";
                TextBoxPassword.Text = "";
                TextBoxCorreo.Focus();
            }

            
                            
        }
    }
}