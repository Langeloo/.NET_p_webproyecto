using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Baberia
{
    public class Conexion
    {
        public SqlConnection em;

        public Conexion()
        {
        }

        public SqlConnection conectar()
        {
            try
            {
                em = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Public\\Bases de datos\\Barberia.mdf;Integrated Security=True;Connect Timeout=30");
                em.Open();
                return em;
            }catch(SqlException oe)
            {
                return null;
            }
                
        }
           
        public void Cerrar()
        {
            em.Close();
        }


    }
}