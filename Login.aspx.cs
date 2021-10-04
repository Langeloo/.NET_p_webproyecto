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
        protected void Page_Load(object sender, EventArgs e)
        {
            Index.enlogin = true;
        }

        protected void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioCrud buscar = new UsuarioCrud();
            if (buscar.ComprobarExistencia(TextBoxCorreo.Text))
            {
                Usuario objeto = new Usuario(TextBoxCorreo.Text,TextBoxPassword.Text,"","","","","",0);

                if (buscar.ComprobarUsuario(objeto))
                {
                    Index.estadosesion = true;
                    Index.Sesion = 1;
                    Index.user = buscar.BuscarUsuario(objeto);
                    Usuario ob = buscar.BuscarUsuario(objeto);
                    if (ob.getRol().Equals("Barbero"))
                    {
                        Index.roLin = 'b';

                    }else if(ob.getRol().Equals("Usuario"))
                    {
                        Index.roLin = 'u';

                    }
                    else if(ob.getRol().Equals("Administrador"))
                    {
                        Index.roLin = 'a';
                    }


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