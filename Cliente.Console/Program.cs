using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            InventarioServiceReference.WebServiceInventarioSoapClient wsdl = new InventarioServiceReference.WebServiceInventarioSoapClient();
            var datosArreglo = wsdl.ObtenerInventario();
            System.Console.WriteLine("DATOS DEL WEB SERVICE");
            foreach (var item in datosArreglo)
            {
                System.Console.WriteLine(item.NumeroInventario +" "+item.Descripcion+" "+item.Precio+" "+item.Color );
            }
            System.Console.ReadKey();
        }
    }
}
