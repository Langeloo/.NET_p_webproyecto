using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //Usuario ob = new Usuario("LuzAdrua11@gmAIl.com", "12345678", "Carla", "", "Lopez", "Diaz", "Usuario", 18);
           /* Usuario ob = new Usuario("Toto@gmail.com", "12345678", "Carla", "", "Lopez", "Diaz", "Usuario", 18);
            UsuarioCrud ini = new UsuarioCrud();*/
           /* Usuario ob2 = ini.BuscarUsuario(ob);
            if (ob2 != null)
            {
                TextBox1.Text += ob2.getCorreo() + "  " + ob2.getNombre1();
            } else
            {
                TextBox1.Text += "Usuario no encontrado ";
            }*/
            

            

            /*if (o.conectar()!=null)
            {
                
            }else
            {
                
            }
            */
            
            
            CrudCita cliente = new CrudCita();
            CrudBarbero barb = new CrudBarbero();
            List<Cita> lista = cliente.listaDeUsuarios();
            if (lista != null)
                {

                    foreach (Cita u in lista)
                    {


                    if (u.getCorreobarbero().Equals("Edwin@gmail.com") && u.getCorreocliente().Equals("Cliente@gmail.com"))
                    {
                       if (u.getHora().Equals("11:00:00") && u.getFecha().Equals("03/10/2021"))
                        {
                            TextBox1.Text += u.getCorreobarbero() + "\n" + u.getHora();
                            break;
                        }
                            
                        
                        
                    }
                    
                        

                    }
                }
                else
                {
                    TextBox1.Text += "NO SE HIZO NI MIERDA ERROR";
                }
          
            
            


            

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

            /*if(ini.BuscarUsuario(ob)!=null)
            {
                Usuario ob2 = ini.BuscarUsuario(ob);

                TextBox1.Text += ob2.getCorreo() +" "+ ob2.getNombre1();
            }
            else
            {
                TextBox1.Text = "El usuario buscado no está en la base de datos";
            }*/
          
        }
    }
}