using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistrarse_Click(object sender, EventArgs e)
        {
            Usuario ob = new Usuario();
            UsuarioCrud a = new UsuarioCrud();

            if(!a.ComprobarExistencia(TextRBoxCorreo.Text) && TextRBoxCorreo.Text.Contains("."))
            {
                ob.setCorreo(TextRBoxCorreo.Text);
                ob.setPassword(TextBoxRPassword.Text);
                ob.setNombre1(TextBoxNom1.Text);
                if (TextBoxNom2.Text == null || TextBoxNom2.Text == "")
                {
                    ob.setNombre2("");
                }
                {
                    ob.setNombre2(TextBoxNom2.Text);
                }

                ob.setApellido1(TextBoxApellido1.Text);
                ob.setApellido2(TextBoxApellido2.Text);
                ob.setRol(DropDownListRol.SelectedValue.ToString());
                ob.setEdad(int.Parse(TextBoxEdad.Text));

                UsuarioCrud insertar = new UsuarioCrud();
                if (insertar.InsertarUsuario(ob))
                {
                    insertar.InsertarUsuario(ob);
                    Response.Write("<script>alert('Datos Registrados con éxito');</script>");
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Datos los datos no fueron registrados con éxito por favor intente con éxito');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('EL USUARIO YA ESTA REGISTRADO O CORREO INVALIDO POR FAVOR INTENTE DE NUEVO');</script>");
            }
            
            

        }

        protected void DropDownListRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}