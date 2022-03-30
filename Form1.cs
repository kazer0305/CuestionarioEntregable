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
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            //Abre el formulario #2
            Form2 MiForma2 = new Form2();
            MiForma2.Show();
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            //Abre el formulario #3
            Form3 MiForma3 = new Form3();
            MiForma3.Show();
        }
    }
}
