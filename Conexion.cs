using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;

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
            
                em = new SqlConnection("server=localhost;user id=root;database=barberia");
                em.Open();
                return em;
        }
           
                

               
 
        
        public void Cerrar()
        {
            em.Close();
        }


    }
}