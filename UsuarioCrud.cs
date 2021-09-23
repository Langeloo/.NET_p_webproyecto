using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baberia
{
    
    public class UsuarioCrud
    {
        public Boolean InsertarUsuario(Usuario ob)
        {
            Conexion con = new Conexion();
            MySqlDataReader reader = null;
            String sql = "INSERT INTO USUARIO (correo, password,nombre1,nombre2,apellido1,apellido2,rol,edad) " +
                "VALUES('"+ob.getCorreo()+"'," +
                        "'"+ob.getPassword()+"'," +
                        "'"+ob.getNombre1()+"'," +
                        "'"+ob.getNombre2()+"'," +
                        "'"+ob.getApellido1()+"'"+ 
                        "'"+ob.getApellido2()+ "'," +
                        "'"+ob.getRol()+"'," +
                        "'"+ob.getEdad() + "');";

            try
            {
                con.conectar();
                MySqlCommand cmd = new MySqlCommand(sql , con.conectar());
                cmd.ExecuteNonQuery();



            }
            catch
            {
                return false;
            }finally
            {
                con.Cerrar();
                if(reader!=null)
                reader.Close();
            }



            return true;
        }
    }
}