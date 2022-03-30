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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Ejecuta el método static ExistenciaArchivo de la clase BaseDatos, este método es el encargado de revisar la existencia del archivo
            //Para mayor detalle consultar la clase BaseDatos
            BaseDatos.ExistenciaArchivo();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (txtJugador.Text == "" )
            {
                MessageBox.Show("Debe ingresar un nombre para el jugador", "Campo vacío");
            }
            else if(txtJugador.Text != "")
            {
                nombreJugador = txtJugador.Text;
                //Abre el formulario #2
                Form2 MiForma2 = new Form2();
                MiForma2.Show();
            }
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            //Abre el formulario #3
            Form3 MiForma3 = new Form3();
            MiForma3.Show();
        }

        public static string nombreJugador;
    }
}
