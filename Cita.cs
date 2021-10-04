using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Baberia
{
    public class Cita
    {
        private int id;
        private String fecha;
        private String hora;
        private String Correobarbero;
        private String Correocliente;
        public Cita()
        {
        }

        public Cita(int id,string fecha, string hora, string correobarbero, string correocliente)
        {
            this.id = id;
            this.fecha = fecha;
            this.hora = hora;
            Correobarbero = correobarbero;
            Correocliente = correocliente;
        }

        public Cita(string fecha, string hora, string correobarbero, string correocliente)
        {
            this.fecha = fecha;
            this.hora = hora;
            Correobarbero = correobarbero;
            Correocliente = correocliente;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getFecha()
        {
            return fecha;
        }

        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }

        public String getHora()
        {
            return hora;
        }

        public void setHora(String hora)
        {
            this.hora = hora;
        }

        public String getCorreobarbero()
        {
            return Correobarbero;
        }

        public void setCorreobarbero(String Correobarbero)
        {
            this.Correobarbero = Correobarbero;
        }

        public String getCorreocliente()
        {
            return Correocliente;
        }

        public void setCorreocliente(String Correocliente)
        {
            this.Correocliente = Correocliente;
        }

    }
}