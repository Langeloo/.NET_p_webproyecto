using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Baberia
{
    public class CrudCliente
    {
        public CrudCliente()
        {
        }

        public Boolean InsertarUsuario(Cliente ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "INSERT INTO CLIENTE (correoC,nombres,apellidos,edad) " +
                "VALUES ('" + ob.getCorreo() + "'," +
                        "'" + ob.getNombres() + "'," +
                        "'" + ob.getApellidos() + "'," +
                        +ob.getEdad() + ");";

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
        public Boolean delete(Cliente ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "DELETE FROM CLIENTE WHERE CORREOC='" + ob.getCorreo() + "';";

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

        public Boolean Update(String id, Cliente ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "UPDATE Cliente SET correoC ='" + ob.getCorreo() +
                "',nombres='" + ob.getNombres() + "',apellidos='" + ob.getApellidos() + "',edad=" + ob.getEdad() +
                                                "WHERE CORREOC='" + id + "';";

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

        public List<Cliente> listaDeUsuarios()
        {

            List<Cliente> lista = new List<Cliente>();
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "SELECT * FROM CLIENTE;";

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
                        Cliente ob = new Cliente();
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

        public Cliente BuscarUsuario(Cliente id)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "SELECT * FROM CLIENTE WHERE CORREOC = '" + id.getCorreo() + "';";
            Cliente ob = null;
            try
            {
                con.conectar();

                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ob = new Cliente();
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