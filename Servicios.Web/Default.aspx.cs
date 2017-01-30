using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Servicios.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InvetanriosServiceReference.WebServiceInventarioSoapClient wsdl = new InvetanriosServiceReference.WebServiceInventarioSoapClient();
            var datosArreglo = wsdl.ObtenerInventario();
            InventariosGridView.DataSource = datosArreglo;
            InventariosGridView.DataBind();
        }
    }
}