﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Baberia
{
    public partial class Cerrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Index.estadosesion = false;
            Index.user = null;
            Index.Sesion = 2;
            Response.Redirect("Inicio.aspx");
        }
    }
}