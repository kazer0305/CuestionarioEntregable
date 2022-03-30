using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CuestionarioEntregable
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Se instancia y crea un objeto DataTable
        private DataTable TablaConsulta = new DataTable();

        private void Form3_Load(object sender, EventArgs e)
        {
            //Se agregan los valores al objeto DataTable TablaConsulta y se le asigna a la DataGrid estos valores, estos Valores son los encabezados de las columnas
            TablaConsulta.Columns.Add("Nombre Jugador", typeof(string));
            TablaConsulta.Columns.Add("Puntaje", typeof(string));
            dataGridJugadores.DataSource = TablaConsulta;

            BaseDatos.Ordenar(this.TablaConsulta);
        }
    }
}
