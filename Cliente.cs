using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baberia
{
    public class Cliente
    {
        private String correo;
        private String nombres;
        private String apellidos;
        private int edad;

        public Cliente(string correo,string nombres, string apellidos, int edad)
        {
            this.correo = correo;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public Cliente()
        {
        }
        public String getCorreo()
        {
            return this.correo;
        }

        public void setCorreo(String nombres)
        {
            this.correo = nombres;
        }
        public String getNombres()
        {
            return nombres;
        }

        public void setNombres(String nombres)
        {
            this.nombres = nombres;
        }

        public String getApellidos()
        {
            return apellidos;
        }

        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }


    }
}