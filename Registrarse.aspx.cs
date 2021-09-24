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

            ob.setCorreo(TextRBoxCorreo.Text);
            ob.setPassword(TextBoxRPassword.Text);
            ob.setNombre1(TextBoxNom1.Text);
            ob.setNombre2(TextBoxNom2.Text);
            ob.setApellido1(TextBoxApellido1.Text);
            ob.setApellido2(TextBoxApellido2.Text);
            ob.setRol(DropDownListRol.SelectedValue.ToString());
            ob.setEdad(int.Parse(TextBoxEdad.Text));

            UsuarioCrud insertar = new UsuarioCrud();
            if(insertar.InsertarUsuario(ob)==true)
            {
                insertar.InsertarUsuario(ob);
                Response.Write("<script>alert('Datos Registrados con éxito');</script>");
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                Response.Write("<script>alert('Datos los datos no fueron registrados con éxito');</script>");
            }
            

        }
    }
}