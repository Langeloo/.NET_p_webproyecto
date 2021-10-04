using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Baberia
{
    public class CrudCita
    {
        public Boolean InsertarUsuario(Cita ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "INSERT INTO CITA (fechacita,horacita,FK_CorreoBarbero,FK_CorreoCliente) " +
                "VALUES ('" + ob.getFecha() + "'," +
                        "'" + ob.getHora() + "'," +
                        "'" + ob.getCorreobarbero() + "'," +
                        "'"+ob.getCorreocliente() + "')";

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
        public Boolean delete(Cita ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "DELETE FROM CITA WHERE ID='" + ob.getId() + "';";

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

        public Boolean Update(int id, Cita ob)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "UPDATE CITA SET FECHACITA ='" + ob.getFecha() +
                "',HORACITA='" + ob.getHora() + "',FK_CORREOBARBERO='" + ob.getCorreobarbero() + "',FK_CORREOCLIENTEE= '" + ob.getCorreocliente() +"' "+
                                                "WHERE ID=" + id + ";";

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

        public List<Cita> listaDeUsuarios()
        {

            List<Cita> lista = new List<Cita>();
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "SELECT * FROM CITA;";

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
                        Cita ob = new Cita();
                        ob.setId(reader.GetInt32(0));
                        ob.setFecha(reader.GetDateTime(1).ToString("dd/MM/yyyy"));
                        ob.setHora(reader.GetTimeSpan(2).ToString());
                        ob.setCorreobarbero(reader.GetString(3));
                        ob.setCorreocliente(reader.GetString(4));
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

        public Cita BuscarUsuario(Cita id)
        {
            Conexion con = new Conexion();
            SqlDataReader reader = null;
            String sql = "SELECT * FROM CITA WHERE ID = '" + id.getId() + "';";
            Cita ob = null;
            try
            {
                con.conectar();

                SqlCommand cmd = new SqlCommand(sql, con.conectar());
                reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
                    ob = new Cita();
                    ob.setId(reader.GetInt32(0));
                    ob.setFecha(reader.GetDateTime(1).ToString("dd/MM/yyyy"));
                    ob.setHora(reader.GetTimeSpan(2).ToString());
                    ob.setCorreobarbero(reader.GetString(3));
                    ob.setCorreocliente(reader.GetString(4));
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

        public bool ComprobarCita(Cita ob, String fecha)
        {
            CrudCita cliente = new CrudCita();
            bool s = false;
            List<Cita> lista = cliente.listaDeUsuarios();
            if (lista != null)
            {
                
                foreach (Cita u in lista)
                {

                    
                    if (u.getCorreobarbero().Equals(ob.getCorreobarbero()))
                    {
                        if (u.getHora().Equals(ob.getHora()) && u.getFecha().Equals(fecha))
                        {
                            s = true;
                            break;
                        }
                    }

                }
                return s;
            }
            else
            {
                return false ;
            }


        }

    }
}