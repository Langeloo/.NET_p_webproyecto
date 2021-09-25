using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class pruebas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario ob = new Usuario("Administrador@gmAIl.com", "12345678", "David", "Santiago", "Lopez", "Diaz", "Barbero", 32);
            UsuarioCrud ini = new UsuarioCrud();
            //bool uwu = ini.InsertarUsuario(ob);
            /*TextBox1.Text += "INSERT INTO USUARIO (correo,password,nombre1,nombre2,apellido1,apellido2,rol,edad) " +
                "VALUES ('" + ob.getCorreo() + "'," +
                        "'" + ob.getPassword() + "'," +
                        "'" + ob.getNombre1() + "'," +
                        "'" + ob.getNombre2() + "'," +
                        "'" + ob.getApellido1() + "'" +
                        "'" + ob.getApellido2() + "'," +
                        "'" + ob.getRol() + "'," +
                         + ob.getEdad() + ");" + uwu;*/

            /*List<Usuario> lista = ini.listaDeUsuarios();
            foreach(Usuario u in lista)
            {
                TextBox1.Text += u.getCorreo() + " " + u.getPassword() + "\n";
            }*/

            /* if(ini.ComprobarExistencia("CRISTIANVinasco@hotmail.com"))
             {
                 TextBox1.Text = "El usuario si esixte";
             }
             else
             {
                 TextBox1.Text = "El usuario NO esixte";
             }*/

            /* Usuario ob2 = ini.BuscarUsuario(ob);
             if(ini.ComprobarExistencia(ob.getCorreo()))
             {
                 if(ini.ComprobarUsuario(ob))
                 {
                     TextBox1.Text += "Acceso";
                 }else
                 {
                     TextBox1.Text += "NOOOOOO";
                 }

             }
             else
             {
                 TextBox1.Text += "no Acceso";
                 TextBox1.Text += ob2.getCorreo();
             }*/

            //List<Usuario> lista = ini.listaDeUsuarios();


            /*if(ini.ComprobarUsuario(ob))
              {
                TextBox1.Text +=  "Acceso correcto";
              }
              else
              {
                  TextBox1.Text += "Acceso NOOOOOOOOOOOOOOOO";
              }*/

            if(ini.BuscarUsuario(ob)!=null)
            {
                Usuario ob2 = ini.BuscarUsuario(ob);

                TextBox1.Text += ob2.getCorreo() +" "+ ob2.getNombre1();
            }
            else
            {
                TextBox1.Text = "El usuario buscado no está en la base de datos";
            }
          
        }
    }
}