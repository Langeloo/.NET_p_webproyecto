using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class citasCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NombreUser.InnerText = Index.user.getNombre1();
            GridViewCita.DataBind();
        }

        protected void ButtonCita_Click(object sender, EventArgs e)
        {
            CrudCita cita = new CrudCita();
            Cita ob = new Cita();

            ob.setFecha(TextBoxFecha.Text);
            ob.setHora(DropDownListHora.SelectedValue.ToString());
            ob.setCorreobarbero(DropDownListBarberos.SelectedValue.ToString());
            ob.setCorreocliente(Index.user.getCorreo());

            if(!cita.ComprobarCita(ob, Convert.ToDateTime(TextBoxFecha.Text).ToString("dd/MM/yyyy")))
            {
                if (cita.InsertarUsuario(ob))
                {

                    cita.InsertarUsuario(ob);
                    Response.Write("<script>alert('La cita se registró con éxito!!!!');</script>");

                }
                else
                {
                    Response.Write("<script>alert('La cita no registró con éxito, verifique los datos');</script>");
                }
            }else
            {
                Response.Write("<script>alert('El barbero YA TIENE AGENDADO ESTE TURNO');</script>");
            }
               
            
        }

        protected void ButtonVerCitas_Click(object sender, EventArgs e)
        {
            /*var consulta = "select Barberos.Nombres as BARBERO, Cita.FechaCita, Cita.HoraCita  from Cita,Barberos,Cliente where Cita.FK_CorreoBarbero = Barberos.CorreoB and Cita.Fk_correoCliente='"+Index.user.getCorreo()+"';";
            var c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Public\\Bases de datos\\Barberia.mdf;Integrated Security=True;Connect Timeout=30"); // Tu String de conexión
            var adaptador = new SqlDataAdapter(consulta, c);

            var commandBuilder = new SqlCommandBuilder(adaptador);
            GridViewCita.DataSource = commandBuilde;
            GridViewCita.DataBind();*/
            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection())
                {
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Public\\Bases de datos\\Barberia.mdf;Integrated Security=True;Connect Timeout=30";
                    using (System.Data.SqlClient.SqlCommand command = conn.CreateCommand())
                    {
                        conn.Open();
                        // Create the sample database
                        command.CommandText = "select Barberos.Nombres as BARBERO, Cita.FechaCita, Cita.HoraCita from Cita,Barberos,Cliente where Cita.FK_CorreoBarbero = Barberos.CorreoB and Cita.Fk_correoCliente = '"+Index.user.getCorreo()+"'; ";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        GridViewCita.DataSource = command.ExecuteReader();
                        GridViewCita.DataBind();
                        conn.Close();
                    }
                }



            }
            catch
            {
            }
        }
    }
}