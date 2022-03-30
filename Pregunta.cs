using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuestionarioEntregable
{
    class Pregunta
    {
        /// <summary>
        /// En esta región se declarará todas los métodos de la clase pregunta
        /// </summary>
        #region Metodos

        public void EstablecerPregunta(string Enunciado)
        {
            TextoPregunta = Enunciado;
        }

        public void EstablecerRespuesta(string Enunciado)
        {
            Respuesta = Enunciado;
        }

        public void EstablecerIncorrecta(int i, string Enunciado)
        {
            switch (i)
            {
                case 1:
                    Incorrecta1 = Enunciado;
                    break;

                case 2:
                    Incorrecta2 = Enunciado;
                    break;

                case 3:
                    Incorrecta3 = Enunciado;
                    break;

                case 4:
                    Incorrecta4 = Enunciado;
                    break;

                case 5:
                    Incorrecta5 = Enunciado;
                    break;

                default: break;
            }
        }

        public void EstablecerDificultad(int i)
        {
            Dificultad = i;
        }

        public string ObtenerPregunta()
        {
            return TextoPregunta;
        }

        public string ObtenerRespuesta()
        {
            return Respuesta;
        }

        public string ObtenerIncorrecta(int i)
        {
            switch (i)
            {
                case 1: return Incorrecta1;

                case 2: return Incorrecta2;

                case 3: return Incorrecta3;

                case 4: return Incorrecta4;

                case 5: return Incorrecta5;

                default: return "";
            }
        }

        public int ObtenerDificultad()
        {
            return Dificultad;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// En esta región se declarará todas las propiedades de la clase Pregunta
        /// </summary>
        private string TextoPregunta;
        private string Respuesta;
        private string Incorrecta1;
        private string Incorrecta2;
        private string Incorrecta3;
        private string Incorrecta4;
        private string Incorrecta5;
        private int Dificultad;

        #endregion
    }
}
