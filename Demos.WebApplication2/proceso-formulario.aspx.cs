using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demos.WebApplication2
{
    public partial class proceso_formulario : System.Web.UI.Page
    {
        public string Nombre = "";
        public string Apellido1 = "";
        public string Apellido2 = "";
        public DateTime FechaNacimiento;
        public string Email = "";
        public string Mensaje = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            //Request GET
            //Nombre = HttpContext.Current.Request.QueryString["nombre"];
            //Nombre = HttpContext.Current.Request.QueryString[0];

            //Request POST
            //Nombre = HttpContext.Current.Request.Form["nombre"];
            //Nombre = HttpContext.Current.Request.Form[0];

            //Request GET y POST
            try
            {
                Nombre = HttpContext.Current.Request.Params["nombre"];
                Apellido1 = HttpContext.Current.Request.Params["apellido1"];
                Apellido2 = HttpContext.Current.Request.Params["apellido2"];
                Email = HttpContext.Current.Request.Params["email"];
                FechaNacimiento =
                    Convert.ToDateTime(HttpContext.Current.Request.Params["fechanacimiento"]);
                Mensaje = "Ficha registrada correctamente";
            }
            catch (Exception ex)
            {
                Mensaje = "Error: " + ex.Message;
            }

        }
    }
}