using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baberia
{
    
    public class UsuarioCrud
    {
        public UsuarioCrud()
        {
        }

        public Boolean InsertarUsuario(Usuario ob)
        {
            Conexion con = new Conexion();
            MySqlDataReader reader = null;
            String sql = "INSERT INTO USUARIO (correo,password,nombre1,nombre2,apellido1,apellido2,rol,edad) " +
                "VALUES ('"+ob.getCorreo()+"'," +
                        "'"+ob.getPassword()+"'," +
                        "'"+ob.getNombre1()+"'," +
                        "'"+ob.getNombre2()+"'," +
                        "'"+ob.getApellido1()+"',"+ 
                        "'"+ob.getApellido2()+ "'," +
                        "'"+ob.getRol()+"'," +
                        +ob.getEdad() + ");";

            try
            {
                con.conectar();
                MySqlCommand cmd = new MySqlCommand(sql , con.conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException oe)
            {
                Console.WriteLine("Error en el insertar datos" + oe);
                return false;
            }finally
            {
                con.Cerrar();
                if(reader!=null)
                reader.Close();
            }
        }
        public Boolean delete(Usuario ob)
        {
            Conexion con = new Conexion();
            MySqlDataReader reader = null;
            String sql = "DELETE FROM USUARIO WHERE CORREO='" + ob.getCorreo() + "';";

            try
            {
                con.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con.conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException oe)
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

        public Boolean Update(String id,Usuario ob)
        {
            Conexion con = new Conexion();
            MySqlDataReader reader = null;
            String sql = "UPDATE USUARIO SET correo ='" + ob.getCorreo() + "',password='" + ob.getPassword() + "',nombre1='" + ob.getNombre1()
                                                + "',nombre2='" + ob.getNombre2() + "',apellido1='" + ob.getApellido1() + "',apellido2='" + ob.getApellido2() + "',rol='" + ob.getRol() + "',edad='" + ob.getEdad() + "'" +
                                                "WHERE CORREO='" + id + "';";

            try
            {
                con.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con.conectar());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException oe)
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

        public List<Usuario> listaDeUsuarios()
        {
            
            List<Usuario> lista = new List<Usuario>();
            Conexion con = new Conexion();
            MySqlDataReader reader = null;
            String sql = "SELECT * FROM USUARIO;";

            try
            {
                con.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, con.conectar());
                reader = cmd.ExecuteReader();
               if (reader.HasRows)
                {
                    lista.Clear();
                    while (reader.Read())
                    {
                        Usuario ob = new Usuario();
                        ob.setCorreo(reader.GetString(0));
                        ob.setPassword(reader.GetString(1));
                        ob.setNombre1(reader.GetString(2));
                        ob.setNombre2(reader.GetString(3));
                        ob.setApellido1(reader.GetString(4));
                        ob.setApellido2(reader.GetString(5));
                        ob.setRol(reader.GetString(6));
                        ob.setEdad(reader.GetInt32(7));
                        lista.Add(ob);
                    }

                    return lista;
                }
                else
                {
                    return null;
                }

            }
            catch (MySqlException oe)
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

        public Usuario BuscarUsuario(Usuario id)
        {
            Conexion con = new Conexion();
            MySqlDataReader reader = null;
            String sql = "SELECT * FROM USUARIO WHERE CORREO = '"+ id.getCorreo()+ "';";
            Usuario ob = null;
            try
            {
                con.conectar();
                
                MySqlCommand cmd = new MySqlCommand(sql, con.conectar());
                reader = cmd.ExecuteReader();
                
                    ob = new Usuario();
                    while (reader.Read())
                    {
                        
                        ob.setCorreo(reader.GetString(0));
                        ob.setPassword(reader.GetString(1));
                        ob.setNombre1(reader.GetString(2));
                        ob.setNombre2(reader.GetString(3));
                        ob.setApellido1(reader.GetString(4));
                        ob.setApellido2(reader.GetString(5));
                        ob.setRol(reader.GetString(6));
                        ob.setEdad(reader.GetInt32(7));
                    }
                return ob;
            }
            catch(MySqlException oe)
            {
                Console.WriteLine("Error en el buscar usuario"+ oe);
                return ob;
            }
            finally
            {
                con.Cerrar();
                if (reader != null)
                    reader.Close();
            }
        }

        public bool ComprobarExistencia(String id)
        {
            List<Usuario> lista = this.listaDeUsuarios();
            if (lista!=null)
            {
                foreach(Usuario a in lista)
                {
                    if (a.getCorreo().ToLower().Equals(id.ToLower()))
                    {
                        return true;
                        break;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool ComprobarUsuario(Usuario ob)
        {
            List<Usuario> lista = this.listaDeUsuarios();
            if (lista != null)
            {
                foreach (Usuario a in lista)
                {
                    if (ComprobarExistencia(ob.getCorreo()))
                    {

                        if (a.getCorreo().ToLower().Equals(a.getCorreo().ToLower()))
                        {
                            if (a.getPassword().Equals(ob.getPassword()))
                            {
                                return true;
                                break;
                            }
                            else
                            {
                                return false;
                                break;
                            }
                        }                       
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

    }

   
}