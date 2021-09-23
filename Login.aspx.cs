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

        }

        protected void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            Conexion ob = new Conexion();
            MySqlDataReader reader = null;
            try
            {
                ob.conectar();
                try
                {
                    String a = TextBoxCorreo.Text;
                    String b = TextBoxPassword.Text;
                    MySqlCommand cmd = new MySqlCommand("select Correo,password from usuario;", ob.conectar());
                    

                    reader = cmd.ExecuteReader();
                    String correo = "";
                    String clave = "";
                    while (reader.Read())
                    {
                        correo = reader.GetString(0) + "\n ";
                        clave = reader.GetString(1) + "\n";
                    }
                }catch(Exception eo)
                {
                    Response.Write("<script>alert('No se realizó la consulta con éxito a la base de datos error:" + eo.Message + "');</script>");
                }
                

               
            }catch(Exception eo)
            {
                Response.Write("<script>alert('No se accedió a la base de datos error:" + eo.Message+"');</script>");
            }
            finally
            {
                reader.Close();
                ob.Cerrar();
            }



        }
    }
}