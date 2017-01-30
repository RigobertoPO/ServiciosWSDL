using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiciosWSDL
{
    /// <summary>
    /// Summary description for WebServiceInventario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceInventario : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public int  SumaNumeros(int Numero1, int numero2)
        {

            return Numero1+numero2;
        }
        [WebMethod]
        public List<Inventario> ObtenerInventario()
        {
            List<Inventario> listaInvetario = new List<Inventario>();  //define la lista
            //Primera forma de llenado
            listaInvetario.Add(new Inventario { NumeroInventario =1,Descripcion="Computadora",Precio=10000,Color="Rojo" });
            listaInvetario.Add(new Inventario { NumeroInventario = 2, Descripcion = "Laptop", Precio = 5600, Color = "Negro" });
            listaInvetario.Add(new Inventario { NumeroInventario = 3, Descripcion = "Silla ejecutiva", Precio = 1600, Color = "Verde" });
            listaInvetario.Add(new Inventario { NumeroInventario = 4, Descripcion = "Mesa de centro", Precio = 2300, Color = "Azul" });
            //segunda forma de llenado
            Inventario nuevoInventario = new Inventario();
            nuevoInventario.NumeroInventario = 5;
            nuevoInventario.Descripcion = "Bocinas Sony";
            nuevoInventario.Precio = 530;
            nuevoInventario.Color = "Rojo";
            listaInvetario.Add(nuevoInventario);
            return listaInvetario;
        }

    }
}
