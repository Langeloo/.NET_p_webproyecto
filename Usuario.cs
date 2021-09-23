using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baberia
{
    public class Usuario
    {
        private String correo;
        private String password;
        private String nombre1;
        private String nombre2;
        private String apellido1;
        private String apellido2;
        private String Rol;
        private int edad;

        public Usuario(string correo, string password, string nombre1, string nombre2, string apellido1, string apellido2,string rol ,int edad)
        {
            this.correo = correo;
            this.password = password;
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.Rol = rol;
            this.edad = edad;
        }
        public String getCorreo()
        {
            return correo;
        }

        public void setRol(String correo)
        {
            this.Rol = correo;
        }
        public String getRol()
        {
            return this.Rol;
        }

        public void setCorreo(String correo)
        {
            this.correo = correo;
        }
        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getNombre1()
        {
            return nombre1;
        }

        public void setNombre1(String nombre1)
        {
            this.nombre1 = nombre1;
        }

        public String getNombre2()
        {
            return nombre2;
        }

        public void setNombre2(String nombre2)
        {
            this.nombre2 = nombre2;
        }

        public String getApellido1()
        {
            return apellido1;
        }

        public void setApellido1(String apellido1)
        {
            this.apellido1 = apellido1;
        }

        public String getApellido2()
        {
            return apellido2;
        }

        public void setApellido2(String apellido2)
        {
            this.apellido2 = apellido2;
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