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
        public MySqlConnection em;

        public Conexion()
        {
        }

        public MySqlConnection conectar()
        {
            
                em = new MySqlConnection("server=localhost;port=3306;user id=root;password=;database=barberia");
                em.Open();
                return em;
        }
           
        public void Cerrar()
        {
            em.Close();
        }


    }
}