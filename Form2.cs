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
    public partial class Form2 : Form
    {
        //Variables enteras usadas para la operación del juego

        //La primera variable es empleada para almacenar números al azar que serán usados
        //como parametros a enviar en el metodo ObtenerIncorrecta de la clase pregunta
        //la cual nos arrojará respuestas incorrectas
        int[] arregloSorteo = new int[4];

        //Posiciones es un arreglo que se usará para poder mostrar 3 respuesas incorrectas y la 
        //respuesta correcta, pero siempre procurando hacer esto sin seguir un orden específico
        //para así evitar que las respuestas siempre esten ubicados en las mismas posiciones
        int[] posiciones = new int[4];

        //Variable que se llenará con un número aleatorio para siempre cambiar la posicion de la
        //respuesta correcta
        int posicionRespuesta = new int();

        //Valor ques se llenará con un número aleatorio que permitirá cambiar la pregunta a realizar
        //en cada categoría de las 5 preguntas
        int rutaPregunta = new int();

        //Instanciamiento de la clase Random, para poder obtener números aleatorios
        Random random = new Random();

        //Instancias de la clase pregunta, donde se almacenarán las 5 preguntas por categoría
        Pregunta Mipregunta1 = new Pregunta();
        Pregunta Mipregunta2 = new Pregunta();
        Pregunta Mipregunta3 = new Pregunta();
        Pregunta Mipregunta4 = new Pregunta();
        Pregunta Mipregunta5 = new Pregunta();

        //Con esta instancia de la clase pregunta, almacenaremos el valor de la pregunta visualizada
        //durante el desarrollo del juego, para así poder obtener las propiedades como las respuestas incorrectas
        //y correctas.
        Pregunta PreguntaArealizar = new Pregunta();

        //Instancia de la clase Puntaje
        Puntaje MiPuntaje = new Puntaje();

        //Instancia de la clase RondaPregunta
        RondaPregunta MiRonda = new RondaPregunta();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Cuando se abre el formulario se comienzad de forma inmediata cargando la primera ronda de pregunas
            //y asignado el valor de la ronda actual como igual a 1
            MiRonda.rondaActual = 1;

            //EstablecerPreguntas se encarga de asignar a las instancias de la clase Pregunta, los valores de las
            //5 preguntas de cada categoría.
            EstablecerPreguntas();

            //CargarPreguntas muestra la pregunta y respuesta en el formulario #2 durante el desarrollo del juego
            CargarPreguntas();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ChequearRespuestas();

            MiRonda.rondaActual += 1;

            if (MiRonda.rondaActual > 5)
            {
                this.Close();
            }

            EstablecerPreguntas();
            CargarPreguntas();
        }

        static bool Contiene(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return true;
            }
            return false;
        }

        int IntPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }

        public void ChequearRespuestas()
        {
            if (rb1.Checked && rb1.Text == PreguntaArealizar.ObtenerRespuesta())
            {
                MessageBox.Show("Correcto");
                MiPuntaje.PuntajeAcumulado += IntPow(2, MiRonda.rondaActual);
                MessageBox.Show(MiPuntaje.PuntajeAcumulado.ToString());
            }
            else if (rb2.Checked && rb2.Text == PreguntaArealizar.ObtenerRespuesta())
            {
                MessageBox.Show("Correcto");
                MiPuntaje.PuntajeAcumulado += IntPow(2, MiRonda.rondaActual);
                MessageBox.Show(MiPuntaje.PuntajeAcumulado.ToString());
            }
            else if (rb3.Checked && rb3.Text == PreguntaArealizar.ObtenerRespuesta())
            {
                MessageBox.Show("Correcto");
                MiPuntaje.PuntajeAcumulado += IntPow(2, MiRonda.rondaActual);
                MessageBox.Show(MiPuntaje.PuntajeAcumulado.ToString());
            }
            else if (rb4.Checked && rb4.Text == PreguntaArealizar.ObtenerRespuesta())
            {
                MessageBox.Show("Correcto");
                MiPuntaje.PuntajeAcumulado += IntPow(2, MiRonda.rondaActual);
                MessageBox.Show(MiPuntaje.PuntajeAcumulado.ToString());
            }
            else
            {
                MessageBox.Show("Incorrecto");
                this.Close();
            }
        }

        public void EstablecerPreguntas()
        {
            if (MiRonda.rondaActual == 1)
            {
                #region Declaración Preguntas Categoría 1: Algunos Lenguajes de Programación.

                //Pregunta #1
                Mipregunta1.EstablecerPregunta("¿Cuál fue el lenguaje de programación diseñado por Guido van Rossum?");
                Mipregunta1.EstablecerRespuesta("Python");
                Mipregunta1.EstablecerIncorrecta(1, "Java");
                Mipregunta1.EstablecerIncorrecta(2, "Javascript");
                Mipregunta1.EstablecerIncorrecta(3, "Golang");
                Mipregunta1.EstablecerIncorrecta(4, "C#");
                Mipregunta1.EstablecerIncorrecta(5, "COBOL");

                //Pregunta #2
                Mipregunta2.EstablecerPregunta("¿Cuál de los siguientes lenguajes de programación es empleado principalmente en diseño web?");
                Mipregunta2.EstablecerRespuesta("Javascript");
                Mipregunta2.EstablecerIncorrecta(1, "C");
                Mipregunta2.EstablecerIncorrecta(2, "C++");
                Mipregunta2.EstablecerIncorrecta(3, "Visual Basic");
                Mipregunta2.EstablecerIncorrecta(4, "Java");
                Mipregunta2.EstablecerIncorrecta(5, "COBOL");

                //Pregunta #3
                Mipregunta3.EstablecerPregunta("¿Cuál lenguaje fue desarrollado por Sun Microsystems?");
                Mipregunta3.EstablecerRespuesta("Java");
                Mipregunta3.EstablecerIncorrecta(1, "Ruby on rails");
                Mipregunta3.EstablecerIncorrecta(2, "Perl");
                Mipregunta3.EstablecerIncorrecta(3, "Golang");
                Mipregunta3.EstablecerIncorrecta(4, "C++");
                Mipregunta3.EstablecerIncorrecta(5, "C");

                //Pregunta #4
                Mipregunta4.EstablecerPregunta("¿Cuál lenguaje es el empleado para desarrollo de aplicaciones en iOS y macOS?");
                Mipregunta4.EstablecerRespuesta("Swift");
                Mipregunta4.EstablecerIncorrecta(1, "Java");
                Mipregunta4.EstablecerIncorrecta(2, "Javascript");
                Mipregunta4.EstablecerIncorrecta(3, "Python");
                Mipregunta4.EstablecerIncorrecta(4, "Perl");
                Mipregunta4.EstablecerIncorrecta(5, "COBOL");

                //Pregunta #5
                Mipregunta5.EstablecerPregunta("¿Cuál fue el lenguaje de programación diseñado por Bjarne Stroustrup?");
                Mipregunta5.EstablecerRespuesta("C++");
                Mipregunta5.EstablecerIncorrecta(1, "C");
                Mipregunta5.EstablecerIncorrecta(2, "Javascript");
                Mipregunta5.EstablecerIncorrecta(3, "PHP");
                Mipregunta5.EstablecerIncorrecta(4, "C#");
                Mipregunta5.EstablecerIncorrecta(5, "COBOL");

                #endregion
            }

            if (MiRonda.rondaActual == 2)
            {
                #region Declaración Preguntas Categoría 2: Conceptos de lenguajes de programación.

                //Pregunta #1
                Mipregunta1.EstablecerPregunta("¿Qué entendemos como lenguaje de programación?");
                Mipregunta1.EstablecerRespuesta("Una manera definida para escribir instrucciones claras para programar aplicaciones de alto nivel");
                Mipregunta1.EstablecerIncorrecta(1, "Una manera de comunicarse con el hardware");
                Mipregunta1.EstablecerIncorrecta(2, "Lo relacionado con la codificación de páginas web y sitios interactivos");
                Mipregunta1.EstablecerIncorrecta(3, "Una forma de diseñar código para la máquina");
                Mipregunta1.EstablecerIncorrecta(4, "La forma en que el ser humano se comunica con la máquina");
                Mipregunta1.EstablecerIncorrecta(5, "Una descripción formal matemática de la semántica");

                //Pregunta #2
                Mipregunta2.EstablecerPregunta("Es un paradigma de programación orientado a un modelo abstracto de la realidad.");
                Mipregunta2.EstablecerRespuesta("Orientada a objetos");
                Mipregunta2.EstablecerIncorrecta(1, "Funcional");
                Mipregunta2.EstablecerIncorrecta(2, "Estructural");
                Mipregunta2.EstablecerIncorrecta(3, "Lógico");
                Mipregunta2.EstablecerIncorrecta(4, "Matemático");
                Mipregunta2.EstablecerIncorrecta(5, "Procedimental");

                //Pregunta #3
                Mipregunta3.EstablecerPregunta("Cuando hablamos de un lenguaje compilado nos referimos a...");
                Mipregunta3.EstablecerRespuesta("Un lenguaje que requiere pasar por un proceso de transformación a código de máquina");
                Mipregunta3.EstablecerIncorrecta(1, "Un lenguaje de máquina orientado al hardware");
                Mipregunta3.EstablecerIncorrecta(2, "Una manera definida para escribir instrucciones claras para programar aplicaciones de alto nivel");
                Mipregunta3.EstablecerIncorrecta(3, "Un lenguaje que requiere de un controlador específico para que pueda correr");
                Mipregunta3.EstablecerIncorrecta(4, "Un lenguaje de programación que traduce código nativo");
                Mipregunta3.EstablecerIncorrecta(5, "Un lenguaje que es corregido en tiempo real por medio de software");

                //Pregunta #4
                Mipregunta4.EstablecerPregunta("Son nombres de lenguajes de programación orientados a objetos.");
                Mipregunta4.EstablecerRespuesta("Java, C++, Smalltalk, Python, Object Pascal, Visual .net, Visual Basic, Delphi, Perl");
                Mipregunta4.EstablecerIncorrecta(1, "HTML, COBOL, C++, .NET, Lisp, VML, Java, PHP");
                Mipregunta4.EstablecerIncorrecta(2, "Actionscript, COBOL, C++, .NET, PHP, Simula, PowerBuilder, Maya, entre otros");
                Mipregunta4.EstablecerIncorrecta(3, "Visual Basic, Visual C++, Visual DialogScript, Visual Foxpro, Ensamblador, Borland c, Turbo C");
                Mipregunta4.EstablecerIncorrecta(4, "Actionscript, COBOL, C#, .NET, PHP, Simula, PowerBuilder, Maya, entre otros");
                Mipregunta4.EstablecerIncorrecta(5, "HTML, XML, VML, Java, PHP, C++, Fortran, Cobol, Lisp, entre otros");

                //Pregunta #5
                Mipregunta5.EstablecerPregunta("¿Que es un intérprete de lenguaje de programación?");
                Mipregunta5.EstablecerRespuesta("Es un programa informático capaz de analizar y ejecutar otros programas, escritos en un lenguaje de alto nivel.");
                Mipregunta5.EstablecerIncorrecta(1, "Es un programa que transforma código fuente escrito en java a un código neutral a la plataforma conocido como Java");
                Mipregunta5.EstablecerIncorrecta(2, "Es un entorno de desarrollo integrado libre, hecho principalmente para el lenguaje de programación Java");
                Mipregunta5.EstablecerIncorrecta(3, "Define los elementos de dicho lenguaje y cómo se combinan para formar un programa");
                Mipregunta5.EstablecerIncorrecta(4, "Es un atributo de una parte de los datos que indica al ordenador (y/o al programador) algo sobre la clase de datos sobre los que se va a procesar");
                Mipregunta5.EstablecerIncorrecta(5, "Es una orden que se le da al programa para realizar una tarea específica");

                #endregion
            }

            if (MiRonda.rondaActual == 3)
            {
                #region Declaración Preguntas Categoría 3: Lógica de programación.

                //Pregunta #1
                Mipregunta1.EstablecerPregunta("Si quiero iterar o recorrer una colección de objetos, ¿qué puedo usar?");
                Mipregunta1.EstablecerRespuesta("foreach");
                Mipregunta1.EstablecerIncorrecta(1, "do-while");
                Mipregunta1.EstablecerIncorrecta(2, "if-else");
                Mipregunta1.EstablecerIncorrecta(3, "for");
                Mipregunta1.EstablecerIncorrecta(4, "if");
                Mipregunta1.EstablecerIncorrecta(5, "while");

                //Pregunta #2
                Mipregunta2.EstablecerPregunta("var plan = customer == null ? plan.basico():customer.plan(); ¿Qué pasaría si el customer no existe?");
                Mipregunta2.EstablecerRespuesta("El plan es el básico");
                Mipregunta2.EstablecerIncorrecta(1, "El plan no se puede definir");
                Mipregunta2.EstablecerIncorrecta(2, "El plan es según el consumidor");
                Mipregunta2.EstablecerIncorrecta(3, "Saca un error en el código");
                Mipregunta2.EstablecerIncorrecta(4, "El plan es igual a null");
                Mipregunta2.EstablecerIncorrecta(5, "El plan básico pasar a ser según el consumidor");

                //Pregunta #3
                Mipregunta3.EstablecerPregunta("Una etiqueta HTML que se usa para mostrar un título resaltado en negrilla:");
                Mipregunta3.EstablecerRespuesta("<H3></H3>");
                Mipregunta3.EstablecerIncorrecta(1, "<TITLE></TITLE>");
                Mipregunta3.EstablecerIncorrecta(2, "<B></B>");
                Mipregunta3.EstablecerIncorrecta(3, "<TH></TH>");
                Mipregunta3.EstablecerIncorrecta(4, "<BR></BR>");
                Mipregunta3.EstablecerIncorrecta(5, "<BOLD></BOLD");

                //Pregunta #4
                Mipregunta4.EstablecerPregunta(" Una consulta para ejecutar todos los datos de una tabla llamada PERSONA, tiene la siguiente estructura:");
                Mipregunta4.EstablecerRespuesta("SELECT * FROM PERSONA");
                Mipregunta4.EstablecerIncorrecta(1, "SELECT FROM PERSONA");
                Mipregunta4.EstablecerIncorrecta(2, "SELECT ALL FROM PERSONA");
                Mipregunta4.EstablecerIncorrecta(3, "SELECT FROM PERSONA ALL TABLES");
                Mipregunta4.EstablecerIncorrecta(4, "SELECT PERSONAS");
                Mipregunta4.EstablecerIncorrecta(5, "SELECT * ALL PERSONAS");
                
                //Pregunta #5
                Mipregunta5.EstablecerPregunta("El resultado de C, de la siguiente operación: C = 10 % 3;");
                Mipregunta5.EstablecerRespuesta("C = 1");
                Mipregunta5.EstablecerIncorrecta(1, "C = 2");
                Mipregunta5.EstablecerIncorrecta(2, "C = 3");
                Mipregunta5.EstablecerIncorrecta(3, "C = 3.33333");
                Mipregunta5.EstablecerIncorrecta(4, "C = 0");
                Mipregunta5.EstablecerIncorrecta(5, "Ninguna de las anteriores");

                #endregion
            }

            if (MiRonda.rondaActual == 4)
            {
                #region Declaración Preguntas Categoría 4: Programación orientada a objetos.

                //Pregunta #1
                Mipregunta1.EstablecerPregunta("¿Que es la Herencia en Programación orientado a objetos?");
                Mipregunta1.EstablecerRespuesta("Consiste en hacer uso de los atributos o métodos de una clase dentro de otra como si le perteneciera a este mismo");
                Mipregunta1.EstablecerIncorrecta(1, "Son similares a las variables de instancia, con la excepción de que los valores que guardan son los mismos para todos los objetos de una clase");
                Mipregunta1.EstablecerIncorrecta(2, "Es un nombre que identifica a una variable, a un método o función miembro, a una clase");
                Mipregunta1.EstablecerIncorrecta(3, "Define los elementos de dicho lenguaje y cómo se combinan para formar un programa");
                Mipregunta1.EstablecerIncorrecta(4, "Es una orden que se le da al programa para realizar una tarea específica");
                Mipregunta1.EstablecerIncorrecta(5, "Es un método especial de una clase que se llama automáticamente siempre que se declara un objeto de esa clase");

                //Pregunta #2
                Mipregunta2.EstablecerPregunta("Una clase es...");
                Mipregunta2.EstablecerRespuesta("Son varios objetos heredados");
                Mipregunta2.EstablecerIncorrecta(1, "Un método de programación");
                Mipregunta2.EstablecerIncorrecta(2, "Es una categoría del mismo tipo");
                Mipregunta2.EstablecerIncorrecta(3, "Un paradigma de programación");
                Mipregunta2.EstablecerIncorrecta(4, "Un ciclo de programación");
                Mipregunta2.EstablecerIncorrecta(5, "Un entorno de programación integrado");

                //Pregunta #3
                Mipregunta3.EstablecerPregunta("¿Que es la encapsulación en Programación orientado a objetos?");
                Mipregunta3.EstablecerRespuesta("Es la forma de proteger u ocultar las propiedades de un objeto");
                Mipregunta3.EstablecerIncorrecta(1, "Son varios objetos heredados");
                Mipregunta3.EstablecerIncorrecta(2, "Consiste en hacer uso de los atributos o métodos de una clase dentro de otra como si le perteneciera a este mismo");
                Mipregunta3.EstablecerIncorrecta(3, "Es un nombre que identifica a una variable, a un método o función miembro, a una clase");
                Mipregunta3.EstablecerIncorrecta(4, "Es asignar una variable dentro de otra de forma sucesiva, quedando esta encapsulada");
                Mipregunta3.EstablecerIncorrecta(5, "Ninguna de las anteriores");

                //Pregunta #4
                Mipregunta4.EstablecerPregunta("¿Que es el polimorfismo en Programación orientado a objetos?");
                Mipregunta4.EstablecerRespuesta("Podemos definirlo como la capacidad que tienen los objetos de comportarse de múltiples formas recurriendo a la herencia");
                Mipregunta4.EstablecerIncorrecta(1, "Es la forma de proteger u ocultar las propiedades de un objeto");
                Mipregunta4.EstablecerIncorrecta(2, "Son varios objetos heredados");
                Mipregunta4.EstablecerIncorrecta(3, "Consiste en hacer uso de los atributos o métodos de una clase dentro de otra como si le perteneciera a este mismo");
                Mipregunta4.EstablecerIncorrecta(4, "Consiste en tener un método con el mismo nombre pero diferentes parámetros.");
                Mipregunta4.EstablecerIncorrecta(5, "Ninguna de las anteriores");

                //Pregunta #5
                Mipregunta5.EstablecerPregunta("¿Que es Sobrecarga de métodos?");
                Mipregunta5.EstablecerRespuesta("Ninguna de las anteriores");
                Mipregunta5.EstablecerIncorrecta(1, "Podemos definirlo como la capacidad que tienen los objetos de comportarse de múltiples formas recurriendo a la herencia");
                Mipregunta5.EstablecerIncorrecta(2, "Consiste en hacer uso de los atributos o métodos de una clase dentro de otra como si le perteneciera a este mismo");
                Mipregunta5.EstablecerIncorrecta(3, "Es la forma de proteger u ocultar las propiedades de un objeto");
                Mipregunta5.EstablecerIncorrecta(4, "Podemos definirlo como la capacidad que tienen los objetos de comportarse de múltiples formas recurriendo a la herencia");
                Mipregunta5.EstablecerIncorrecta(5, "No es un concepto empleado en POO");

                #endregion
            }

            if (MiRonda.rondaActual == 5)
            {
                #region Declaración Preguntas Categoría 5: Java.

                //Pregunta #1
                Mipregunta1.EstablecerPregunta("Permite crear un archivo “.jar” en NetBeans");
                Mipregunta1.EstablecerRespuesta("Shift +F11");
                Mipregunta1.EstablecerIncorrecta(1, "Shift +F10");
                Mipregunta1.EstablecerIncorrecta(2, "Shift +F9");
                Mipregunta1.EstablecerIncorrecta(3, "Shift +F2");
                Mipregunta1.EstablecerIncorrecta(4, "Shift +F8");
                Mipregunta1.EstablecerIncorrecta(5, "Ninguna de las anteriores");

                //Pregunta #2
                Mipregunta2.EstablecerPregunta("Para que una programa en NetBeans funcione comprende por lo menos 4 cosas, cuales son:");
                Mipregunta2.EstablecerRespuesta("Nombre del proyecto, Clases, Objetos, Codigo");
                Mipregunta2.EstablecerIncorrecta(1, "Nombre del Paquete, Atributos, Pseudocodigo, Compilación");
                Mipregunta2.EstablecerIncorrecta(2, "Compilación, Ejecucion, Creacion del archivo .Jar, Guardar el proyecto");
                Mipregunta2.EstablecerIncorrecta(3, "JDK, IDE, Clases, Objetos");
                Mipregunta2.EstablecerIncorrecta(4, "Nombre del Paquete, Atributos, JDK, IDE");
                Mipregunta2.EstablecerIncorrecta(5, "Creacion del archivo .Jar, Nombre del Paquete, Atributos, JDK");

                //Pregunta #3
                Mipregunta3.EstablecerPregunta("¿Qué librería hay que importar para poder introducir un integer?");
                Mipregunta3.EstablecerRespuesta("java.util.Scanner;");
                Mipregunta3.EstablecerIncorrecta(1, "javax.util.Scanner;");
                Mipregunta3.EstablecerIncorrecta(2, "java.text.Scanner;");
                Mipregunta3.EstablecerIncorrecta(3, "javax.text.Scanner;");
                Mipregunta3.EstablecerIncorrecta(4, "java.text.Math;");
                Mipregunta3.EstablecerIncorrecta(5, "javax.text.Math;");

                //Pregunta #4
                Mipregunta4.EstablecerPregunta("¿Cómo se pasa este String a char? String text = 'W';");
                Mipregunta4.EstablecerRespuesta("text.charAt(0);");
                Mipregunta4.EstablecerIncorrecta(1, "text.parseString();");
                Mipregunta4.EstablecerIncorrecta(2, "String.toChar(text);");
                Mipregunta4.EstablecerIncorrecta(3, "Char.toChar(text);");
                Mipregunta4.EstablecerIncorrecta(4, "Char.toString(text);");
                Mipregunta4.EstablecerIncorrecta(5, "Char.toString(0);");

                //Pregunta #5
                Mipregunta5.EstablecerPregunta("Si no se especifica una súper clase se asume que se hereda de la clase:");
                Mipregunta5.EstablecerRespuesta("Objects");
                Mipregunta5.EstablecerIncorrecta(1, "Extends");
                Mipregunta5.EstablecerIncorrecta(2, "Implements");
                Mipregunta5.EstablecerIncorrecta(3, "Interface");
                Mipregunta5.EstablecerIncorrecta(4, "Abstract");
                Mipregunta5.EstablecerIncorrecta(5, "Document");

                #endregion
            }
        }

        public void CargarPreguntas()
        {
            for (int i = 0; i < arregloSorteo.Length; i++)
            {
                var next = 0;
                while (true)
                {
                    next = random.Next(1, 6);
                    if (!Contiene(arregloSorteo, next)) break;
                }
                arregloSorteo[i] = next;
            }

            posicionRespuesta = random.Next(0, 4);
            for (int i = 0; i < arregloSorteo.Length; i++)
            {
                posiciones[i] = arregloSorteo[i];
            }
            posiciones[posicionRespuesta] = 0;
            rutaPregunta = random.Next(1, 6);

            //Estos comandos fueron usados durante la elaboración para poder hacer seguimiento al correcto
            //Desarrollo

            //string result = string.Join(" ", posiciones);
            //string ensayo = rutaPregunta.ToString();
            //string ensayo2 = MiRonda.rondaActual.ToString();
            //label1.Text = result + " " + ensayo + " " + ensayo2;

            if (rutaPregunta == 1)
            {
                PreguntaArealizar = Mipregunta1;
            }
            else if (rutaPregunta == 2)
            {
                PreguntaArealizar = Mipregunta2;
            }
            else if (rutaPregunta == 3)
            {
                PreguntaArealizar = Mipregunta3;
            }
            else if (rutaPregunta == 4)
            {
                PreguntaArealizar = Mipregunta4;
            }
            else if (rutaPregunta == 5)
            {
                PreguntaArealizar = Mipregunta5;
            }

            label1.Text = PreguntaArealizar.ObtenerPregunta();

            if (posiciones[0] == 0)
            {
                rb1.Text = PreguntaArealizar.ObtenerRespuesta();
            }
            else
            {
                rb1.Text = PreguntaArealizar.ObtenerIncorrecta(posiciones[0]);
            }

            if (posiciones[1] == 0)
            {
                rb2.Text = PreguntaArealizar.ObtenerRespuesta();
            }
            else
            {
                rb2.Text = PreguntaArealizar.ObtenerIncorrecta(posiciones[1]);
            }

            if (posiciones[2] == 0)
            {
                rb3.Text = PreguntaArealizar.ObtenerRespuesta();
            }
            else
            {
                rb3.Text = PreguntaArealizar.ObtenerIncorrecta(posiciones[2]);
            }

            if (posiciones[3] == 0)
            {
                rb4.Text = PreguntaArealizar.ObtenerRespuesta();
            }
            else
            {
                rb4.Text = PreguntaArealizar.ObtenerIncorrecta(posiciones[3]);
            }
        }
    }
}
