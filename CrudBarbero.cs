using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Baberia
{
    public class CrudBarbero
    {
        public CrudBarbero()
        {
        }

        public Boolean InsertarUsuario(Barbero ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "INSERT INTO BARBEROS (correoB,nombres,apellidos,edad) " +
                "VALUES ('" + ob.getCorreo() + "'," +
                        "'" + ob.getNombres() + "'," +
                        "'" + ob.getApellidos() + "'," +
                        + ob.getEdad() + ");";

            try
            {
                con.conectar();
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException oe)
            {
                Console.WriteLine("Error en el insertar datos" + oe);
                return false;
            }
            finally
            {
                con.Cerrar();
                if (reader != null)
                    reader.Close();
            }
        }
        public Boolean delete(Barbero ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "DELETE FROM BARBEROS WHERE CORREOB='" + ob.getCorreo() + "';";

            try
            {
                con.conectar();
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException oe)
            {
                Console.WriteLine("Error en BORRAR datos" + oe);
                return false;
            }
            finally
            {
                con.Cerrar();
                if (reader != null)
                    reader.Close();
            }
        }

        public Boolean Update(String id, Barbero ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "UPDATE BARBEROS SET correoB ='" + ob.getCorreo() + 
                "',nombres='" + ob.getNombres() + "',apellidos='" + ob.getApellidos() + "',edad=" + ob.getEdad() +
                                                "WHERE CORREOB='" + id + "';";

            try
            {
                con.conectar();
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException oe)
            {
                Console.WriteLine("Error en el insertar datos" + oe);
                return false;
            }
            finally
            {
                con.Cerrar();
                if (reader != null)
                    reader.Close();
            }
        }

        public List<Barbero> listaDeUsuarios()
        {

            List<Barbero> lista = new List<Barbero>();
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "SELECT * FROM Barberos;";

            try
            {
                con.conectar();
                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lista.Clear();
                    while (reader.Read())
                    {
                        Barbero ob = new Barbero();
                        ob.setCorreo(reader.GetString(0));
                        ob.setNombres(reader.GetString(1));
                        ob.setApellidos(reader.GetString(2));
                        ob.setEdad(reader.GetInt32(3));
              
                        lista.Add(ob);
                    }
                    return lista;
                }
                else
                {
                    return null;
                }

            }
            catch (SqlException oe)
            {
                Console.WriteLine("Error en la lista de los usuarios" + oe);
                return null;
            }
            finally
            {
                con.Cerrar();
                if (reader != null)
                    reader.Close();
            }
        }

        public Barbero BuscarUsuario(Barbero id)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "SELECT * FROM BARBERO WHERE CORREOB = '" + id.getCorreo() + "';";
            Barbero ob = null;
            try
            {
                con.conectar();

                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
                    ob = new Barbero();
                    ob.setCorreo(reader.GetString(0));
                    ob.setNombres(reader.GetString(1));
                    ob.setApellidos(reader.GetString(2));
                    ob.setEdad(reader.GetInt32(3));
                }
                return ob;
            }
            catch (SqlException oe)
            {
                Console.WriteLine("Error en el buscar usuario" + oe);
                return null;
            }
            finally
            {
                con.Cerrar();
                if (reader != null)
                    reader.Close();
            }
        }
    }
}