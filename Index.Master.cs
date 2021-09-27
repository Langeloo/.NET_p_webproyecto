using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class Index : System.Web.UI.MasterPage
    {

        public static Boolean activesesion = false;
        public static String inicio = "Inicio.aspx";
        public static String login = "Login.aspx";
        public static Boolean loadlogin = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            lilogin.Visible = !activesesion;
            licerrarsesion.Visible = activesesion;

            if (activesesion)
            {

            }
            /*
            try {
                lilogin.Visible = Boolean.Parse(Request.Params.Get("parametro"));
            }
            catch
            {

            }
            */
            /*
            if (activesesion)
            {
                licerrarsesion.Visible = true;
                btnsesion.Visible = false;
                acerrarsesion.Attributes.Add("href",inicio);
            }
            else
            {
                licerrarsesion.Visible = false;
                lilogin.Visible = true;
                btnsesion.Attributes.Add("href", login);
                aapartarcita.Attributes.Add("href", login);
            }
            */
        }
    }
}