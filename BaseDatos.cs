using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Empleado para poder leer los archivos de texto simple plano

namespace CuestionarioEntregable
{
    class BaseDatos
    {
        //Metodo static para ingresar la ruta de la base de datos
        public static string RutaBaseDatos
        {
            get { return rutabasedatos; }
            set { rutabasedatos = value; }
        }

        public static void Ordenar(DataTable TablaConsulta, ComboBox ComboBoxDocente, Button BtnBuscar)
        {
            //Se limpia los resultados de la consulta anterior para evitar mostrar resultados de consultas anteriores
            TablaConsulta.Rows.Clear();
            //Se crea un array de longitud igual a la cantidad de líneas del archivo
            string[] CantidadLineas = File.ReadAllLines(BaseDatos.RutaBaseDatos);
            //Se instancia un array de longitud no definida
            string[] Valores;
            //Con este primer for se lee la cantidad de valores entre los separadores y estos valores se almacenan en el array Valores
            //Se crea un array Filas de longitud igual a la cantidad de líneas en el array Valores            
            for (int i = 0; i < CantidadLineas.Length; i++)
            {
                Valores = CantidadLineas[i].Split('|');
                string[] Filas = new string[Valores.Length];

                //Se utiliza el comando trim para eliminar los valores en blanco y almacenar los valores tomados del array Valores en el array Filas
                for (int j = 0; j < Valores.Length; j++)
                {
                    Filas[j] = Valores[j].Trim();
                }
                TablaConsulta.Rows.Add(Filas);
            }
            //El siguiente es un filtro que se emplea para mostrar los resultados que se encuentra dentro de la ComboBoxDocente
            TablaConsulta.DefaultView.RowFilter = string.Format("Docente LIKE '%{0}%'", ComboBoxDocente.Text);
            //Desactiva el botón de busqueda una vez se haya realizado la consulta
            BtnBuscar.Enabled = false;
        }

        public static void ExistenciaArchivo()
        {
            //Chequeo para verificar que el archivo donde se almacenan los valores de las asesorías si existe, en caso de que exista
            //se almacena el valor de la ruta, en caso de que no exista se crea y se almacena la misma ruta
            string RutaArchivo = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\BaseDatosCitas.txt";
            if (File.Exists(RutaArchivo))
            {
                BaseDatos.RutaBaseDatos = RutaArchivo;
            }
            else
            {
                File.Create(RutaArchivo);
                BaseDatos.RutaBaseDatos = RutaArchivo;
            }
        }

        //Campo de clase empleado para almacenar la ruta del archivo donde se almacenan los datos
        private static string rutabasedatos;
    }
}
