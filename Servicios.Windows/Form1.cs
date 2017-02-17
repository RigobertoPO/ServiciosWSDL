using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }

        private void CargarDatos()
        {
            InventarioServiceReference.WebServiceInventarioSoapClient wsdl = new InventarioServiceReference.WebServiceInventarioSoapClient();
            var datosArreglo = wsdl.ObtenerInventario();
            InventariodataGridView.DataSource = datosArreglo;
        }

        private void Enviarbutton_Click(object sender, EventArgs e)
        {
            InventarioServiceReference.WebServiceInventarioSoapClient wsdl = new InventarioServiceReference.WebServiceInventarioSoapClient();
            var resultado = wsdl.InsertarInventario(Convert.ToInt32(NumerotextBox.Text),DescripciontextBox.Text,ColorcomboBox.SelectedItem.ToString(),Convert.ToDecimal(PreciotextBox.Text ));
            if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
            else
            { MessageBox.Show("Ocurrio un error"); }
        }


    }
}
