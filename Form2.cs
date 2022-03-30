using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuestionarioEntregable
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Pregunta Mipregunta1 = new Pregunta();
            Pregunta Mipregunta2 = new Pregunta();
            Pregunta Mipregunta3 = new Pregunta();
            Pregunta Mipregunta4 = new Pregunta();
            Pregunta Mipregunta5 = new Pregunta();
            Puntaje MiPuntaje = new Puntaje();

            #region Declaración Preguntas Categoría 1: Lenguajes de Programación.

            //Pregunta #1
            Mipregunta1.EstablecerDificultad(1);
            Mipregunta1.EstablecerPregunta("¿Cuál fue el lenguaje de programación diseñado por Guido van Rossum?");
            Mipregunta1.EstablecerRespuesta("Python");
            Mipregunta1.EstablecerIncorrecta(1, "Java");
            Mipregunta1.EstablecerIncorrecta(2, "Javascript");
            Mipregunta1.EstablecerIncorrecta(3, "Golang");
            Mipregunta1.EstablecerIncorrecta(4, "C#");
            Mipregunta1.EstablecerIncorrecta(5, "COBOL");

            //Pregunta #2
            Mipregunta2.EstablecerDificultad(1);
            Mipregunta2.EstablecerPregunta("¿Cuál de los siguientes lenguajes de programación es empleado principalmente en diseño web?");
            Mipregunta2.EstablecerRespuesta("Javascript");
            Mipregunta2.EstablecerIncorrecta(1, "C");
            Mipregunta2.EstablecerIncorrecta(2, "C++");
            Mipregunta2.EstablecerIncorrecta(3, "Visual Basic");
            Mipregunta2.EstablecerIncorrecta(4, "Java");
            Mipregunta2.EstablecerIncorrecta(5, "COBOL");

            //Pregunta #3
            Mipregunta3.EstablecerDificultad(1);
            Mipregunta3.EstablecerPregunta("¿Cuál lenguaje fue desarrollado por Sun Microsystems?");
            Mipregunta3.EstablecerRespuesta("Java");
            Mipregunta3.EstablecerIncorrecta(1, "Ruby on rails");
            Mipregunta3.EstablecerIncorrecta(2, "Perl");
            Mipregunta3.EstablecerIncorrecta(3, "Golang");
            Mipregunta3.EstablecerIncorrecta(4, "C++");
            Mipregunta3.EstablecerIncorrecta(5, "C");

            //Pregunta #4
            Mipregunta4.EstablecerDificultad(1);
            Mipregunta4.EstablecerPregunta("¿Cuál lenguaje es el empleado para desarrollo de aplicaciones en iOS y macOS?");
            Mipregunta4.EstablecerRespuesta("Swift");
            Mipregunta4.EstablecerIncorrecta(1, "Java");
            Mipregunta4.EstablecerIncorrecta(2, "Javascript");
            Mipregunta4.EstablecerIncorrecta(3, "Python");
            Mipregunta4.EstablecerIncorrecta(4, "Perl");
            Mipregunta4.EstablecerIncorrecta(5, "COBOL");

            //Pregunta #5
            Mipregunta5.EstablecerDificultad(1);
            Mipregunta5.EstablecerPregunta("¿Cuál fue el lenguaje de programación diseñado por Bjarne Stroustrup?");
            Mipregunta5.EstablecerRespuesta("C++");
            Mipregunta5.EstablecerIncorrecta(1, "C");
            Mipregunta5.EstablecerIncorrecta(2, "Javascript");
            Mipregunta5.EstablecerIncorrecta(3, "PHP");
            Mipregunta5.EstablecerIncorrecta(4, "C#");
            Mipregunta5.EstablecerIncorrecta(5, "COBOL");

            #endregion

            #region Declaración Preguntas Categoría 2.

            //Pregunta #1
            Mipregunta1.EstablecerDificultad(2);
            Mipregunta1.EstablecerPregunta("¿Qué entendemos como lenguaje de programación?");
            Mipregunta1.EstablecerRespuesta("Una manera definida para escribir instrucciones claras para programar aplicaciones de alto nivel");
            Mipregunta1.EstablecerIncorrecta(1, "Una manera de comunicarse con el hardware");
            Mipregunta1.EstablecerIncorrecta(2, "Lo relacionado con la codificación de páginas web y sitios interactivos");
            Mipregunta1.EstablecerIncorrecta(3, "Una forma de diseñar código para la máquina");
            Mipregunta1.EstablecerIncorrecta(4, "La forma en que el ser humano se comunica con la máquina");
            Mipregunta1.EstablecerIncorrecta(5, "Una descripción formal matemática de la semántica");

            //Pregunta #2
            Mipregunta2.EstablecerDificultad(2);
            Mipregunta2.EstablecerPregunta("Una clase es...");
            Mipregunta2.EstablecerRespuesta("Son varios objetos heredados");
            Mipregunta2.EstablecerIncorrecta(1, "Un método de programación");
            Mipregunta2.EstablecerIncorrecta(2, "Es una categoría del mismo tipo");
            Mipregunta2.EstablecerIncorrecta(3, "Un paradigma de programación");
            Mipregunta2.EstablecerIncorrecta(4, "Un ciclo de programación");
            Mipregunta2.EstablecerIncorrecta(5, "Un entorno de programación integrado");

            //Pregunta #3
            Mipregunta3.EstablecerDificultad(2);
            Mipregunta3.EstablecerPregunta("Cuando hablamos de un lenguaje compilado nos referimos a...");
            Mipregunta3.EstablecerRespuesta("Un lenguaje que requiere pasar por un proceso de transformación a código de máquina");
            Mipregunta3.EstablecerIncorrecta(1, "Un lenguaje de máquina orientado al hardware");
            Mipregunta3.EstablecerIncorrecta(2, "Una manera definida para escribir instrucciones claras para programar aplicaciones de alto nivel");
            Mipregunta3.EstablecerIncorrecta(3, "Un lenguaje que requiere de un controlador específico para que pueda correr");
            Mipregunta3.EstablecerIncorrecta(4, "Un lenguaje de programación que traduce código nativo");
            Mipregunta3.EstablecerIncorrecta(5, "Un lenguaje que es corregido en tiempo real por medio de software");

            //Pregunta #4
            Mipregunta4.EstablecerDificultad(2);
            Mipregunta4.EstablecerPregunta("El servidor es un proveedor de información y el cliente es un consumidor de información, nos referimos a...");
            Mipregunta4.EstablecerRespuesta("Cliente-Servidor");
            Mipregunta4.EstablecerIncorrecta(1, "Cliente");
            Mipregunta4.EstablecerIncorrecta(2, "Aplicación en la nube");
            Mipregunta4.EstablecerIncorrecta(3, "Servidor-Cliente");
            Mipregunta4.EstablecerIncorrecta(4, "Nube-Cliente");
            Mipregunta4.EstablecerIncorrecta(5, "Servidor-Cliente-Nube");

            //Pregunta #5
            Mipregunta5.EstablecerDificultad(2);
            Mipregunta5.EstablecerPregunta("¿Qué es un algoritmo?");
            Mipregunta5.EstablecerRespuesta("Instrucciones lógicas con un propósito específico");
            Mipregunta5.EstablecerIncorrecta(1, "Una estructura programada orientada a una sintaxis");
            Mipregunta5.EstablecerIncorrecta(2, "Una forma de establecer paradigmas de programación");
            Mipregunta5.EstablecerIncorrecta(3, "Código fuente");
            Mipregunta5.EstablecerIncorrecta(4, "Una funcion matemática");
            Mipregunta5.EstablecerIncorrecta(5, "Instrucciones lógicas de propósito general");

            #endregion

            #region Declaración Preguntas Categoría 3.

            //Pregunta #1
            Mipregunta1.EstablecerDificultad(3);
            Mipregunta1.EstablecerPregunta("Si quiero iterar o recorrer una colección de objetos, ¿qué puedo usar?");
            Mipregunta1.EstablecerRespuesta("foreach");
            Mipregunta1.EstablecerIncorrecta(1, "do-while");
            Mipregunta1.EstablecerIncorrecta(2, "if-else");
            Mipregunta1.EstablecerIncorrecta(3, "for");
            Mipregunta1.EstablecerIncorrecta(4, "if");
            Mipregunta1.EstablecerIncorrecta(5, "while");

            //Pregunta #2
            Mipregunta2.EstablecerDificultad(3);
            Mipregunta2.EstablecerPregunta("Uno de los motores de bases de datos más conocidos es...");
            Mipregunta2.EstablecerRespuesta("MySQL");
            Mipregunta2.EstablecerIncorrecta(1, "Excel");
            Mipregunta2.EstablecerIncorrecta(2, "MATLAB");
            Mipregunta2.EstablecerIncorrecta(3, "R Commander");
            Mipregunta2.EstablecerIncorrecta(4, "VBasic");
            Mipregunta2.EstablecerIncorrecta(5, "Microsoft Access");

            //Pregunta #3
            Mipregunta3.EstablecerDificultad(3);
            Mipregunta3.EstablecerPregunta("Una etiqueta HTML que se usa para mostrar un título resaltado en negrilla:");
            Mipregunta3.EstablecerRespuesta("<H3></H3>");
            Mipregunta3.EstablecerIncorrecta(1, "<TITLE></TITLE>");
            Mipregunta3.EstablecerIncorrecta(2, "<B></B>");
            Mipregunta3.EstablecerIncorrecta(3, "<TH></TH>");
            Mipregunta3.EstablecerIncorrecta(4, "<BR></BR>");
            Mipregunta3.EstablecerIncorrecta(5, "<BOLD></BOLD");

            //Pregunta #4
            Mipregunta4.EstablecerDificultad(3);
            Mipregunta4.EstablecerPregunta(" Una consulta para ejecutar todos los datos de una tabla llamada PERSONA, tiene la siguiente estructura:");
            Mipregunta4.EstablecerRespuesta("SELECT * FROM PERSONA");
            Mipregunta4.EstablecerIncorrecta(1, "SELECT FROM PERSONA");
            Mipregunta4.EstablecerIncorrecta(2, "SELECT ALL FROM PERSONA");
            Mipregunta4.EstablecerIncorrecta(3, "SELECT FROM PERSONA ALL TABLES");
            Mipregunta4.EstablecerIncorrecta(4, "SELECT PERSONAS");
            Mipregunta4.EstablecerIncorrecta(5, "SELECT * ALL PERSONAS");

            //Pregunta #5
            Mipregunta5.EstablecerDificultad(3);
            Mipregunta5.EstablecerPregunta("Los sistemas operativos que son libres y que están basados en Unix son:");
            Mipregunta5.EstablecerRespuesta("Ubuntu");
            Mipregunta5.EstablecerIncorrecta(1, "Windows");
            Mipregunta5.EstablecerIncorrecta(2, "Mac");
            Mipregunta5.EstablecerIncorrecta(3, "Debian");
            Mipregunta5.EstablecerIncorrecta(4, "iOS");
            Mipregunta5.EstablecerIncorrecta(5, "Macintosh");

            #endregion

            #region Declaración Preguntas Categoría 4.

            //Pregunta #1
            Mipregunta1.EstablecerDificultad(4);
            Mipregunta1.EstablecerPregunta("Es un paradigma de programación orientado a un modelo abstracto de la realidad.");
            Mipregunta1.EstablecerRespuesta("Orientada a objetos");
            Mipregunta1.EstablecerIncorrecta(1, "Funcional");
            Mipregunta1.EstablecerIncorrecta(2, "Estructural");
            Mipregunta1.EstablecerIncorrecta(3, "Lógico");
            Mipregunta1.EstablecerIncorrecta(4, "Matemático");
            Mipregunta1.EstablecerIncorrecta(5, "Procedimental");

            //Pregunta #2
            Mipregunta2.EstablecerDificultad(4);
            Mipregunta2.EstablecerPregunta("Son parte de los tipos de variables que se manejan en Programación.");
            Mipregunta2.EstablecerRespuesta("String, Boolean, Char, Integer, int, Double, Float");
            Mipregunta2.EstablecerIncorrecta(1, "De Actionscript, COBOL, C#, .NET, PHP, Simula, PowerBuilder, Maya, entre otros");
            Mipregunta2.EstablecerIncorrecta(2, "Cadena, Boleano, Carácter, Numeros, Entero, Cadena, Boleano, Carácter, Numeros, Entero, entre otros");
            Mipregunta2.EstablecerIncorrecta(3, "Tipo Java, C++, Smalltalk, Python, Object Pascal, Visual .net, Visual Basic, Delphi, Perl, entre otros");
            Mipregunta2.EstablecerIncorrecta(4, "Simbólicos, de estructura, de cadena, de complemento, generales, particulares, entre otros");
            Mipregunta2.EstablecerIncorrecta(5, "HTML, XML, VML, Java, PHP, C++, Fortran, Cobol, Lisp, entre otros");

            //Pregunta #3
            Mipregunta3.EstablecerDificultad(4);
            Mipregunta3.EstablecerPregunta("Son nombres de lenguajes de programación orientado a objetos.");
            Mipregunta3.EstablecerRespuesta("Java, C++, Smalltalk, Python, Object Pascal, Visual .net, Visual Basic, Delphi, Perl");
            Mipregunta3.EstablecerIncorrecta(1, "HTML, COBOL, C++, .NET, Lisp, VML, Java, PHP");
            Mipregunta3.EstablecerIncorrecta(2, "Actionscript, COBOL, C++, .NET, PHP, Simula, PowerBuilder, Maya, entre otros");
            Mipregunta3.EstablecerIncorrecta(3, "Visual Basic, Visual C++, Visual DialogScript, Visual Foxpro, Ensamblador, Borland c, Turbo C");
            Mipregunta3.EstablecerIncorrecta(4, "Actionscript, COBOL, C#, .NET, PHP, Simula, PowerBuilder, Maya, entre otros");
            Mipregunta3.EstablecerIncorrecta(5, "HTML, XML, VML, Java, PHP, C++, Fortran, Cobol, Lisp, entre otros");

            //Pregunta #4
            Mipregunta4.EstablecerDificultad(4);
            Mipregunta4.EstablecerPregunta("¿Que es una unidad de almacenamiento?");
            Mipregunta4.EstablecerRespuesta("Son dispositivos periféricos del sistema, que actúan como medio de soporte para la grabación de programas de usuario, así como de datos y archivos.");
            Mipregunta4.EstablecerIncorrecta(1, "Es un Disco duro que sirve para Formateo de sistema operativo y para su uso posterior");
            Mipregunta4.EstablecerIncorrecta(2, "Es aquella que tiene relación con el almacenamiento de la Información y sus usos; es más cercana a las Personas y Computadoras");
            Mipregunta4.EstablecerIncorrecta(3, "Están construidos de material plástico flexible, el cual está recubierto de material magnético (ferromagnético) sobre el cual se grabarán los datos");
            Mipregunta4.EstablecerIncorrecta(4, "Unidad encargada de procesar datos de forma permanente durante la operación de computador");
            Mipregunta4.EstablecerIncorrecta(5, "Ninguna de las anteriores");

            //Pregunta #5
            Mipregunta5.EstablecerDificultad(4);
            Mipregunta5.EstablecerPregunta("Permite crear un archivo “.jar” en NetBeans");
            Mipregunta5.EstablecerRespuesta("Shift +F11");
            Mipregunta5.EstablecerIncorrecta(1, "Shift +F10");
            Mipregunta5.EstablecerIncorrecta(2, "Shift +F9");
            Mipregunta5.EstablecerIncorrecta(3, "Shift +F2");
            Mipregunta5.EstablecerIncorrecta(4, "Shift +F8");
            Mipregunta5.EstablecerIncorrecta(5, "Ninguna de las anteriores");

            #endregion

            #region Declaración Preguntas Categoría 5: Java.

            //Pregunta #1
            Mipregunta1.EstablecerDificultad(5);
            Mipregunta1.EstablecerPregunta("var plan = customer == null ? plan.basico():customer.plan(); ¿Qué pasaría si el customer no existe?");
            Mipregunta1.EstablecerRespuesta("El plan es el básico");
            Mipregunta1.EstablecerIncorrecta(1, "El plan no se puede definir");
            Mipregunta1.EstablecerIncorrecta(2, "El plan es según el consumidor");
            Mipregunta1.EstablecerIncorrecta(3, "Saca un error en el código");
            Mipregunta1.EstablecerIncorrecta(4, "El plan es igual a null");
            Mipregunta1.EstablecerIncorrecta(5, "El plan básico pasar a ser según el consumidor");

            //Pregunta #2
            Mipregunta2.EstablecerDificultad(5);
            Mipregunta2.EstablecerPregunta("Para que una programa en NetBeans funcione comprende por lo menos 4 cosas, cuales son:");
            Mipregunta2.EstablecerRespuesta("Nombre del proyecto, Clases, Objetos, Codigo");
            Mipregunta2.EstablecerIncorrecta(1, "Nombre del Paquete, Atributos, Pseudocodigo, Compilación");
            Mipregunta2.EstablecerIncorrecta(2, "Compilación, Ejecucion, Creacion del archivo .Jar, Guardar el proyecto");
            Mipregunta2.EstablecerIncorrecta(3, "JDK, IDE, Clases, Objetos");
            Mipregunta2.EstablecerIncorrecta(4, "Nombre del Paquete, Atributos, JDK, IDE");
            Mipregunta2.EstablecerIncorrecta(5, "Creacion del archivo .Jar, Nombre del Paquete, Atributos, JDK");

            //Pregunta #3
            Mipregunta3.EstablecerDificultad(5);
            Mipregunta3.EstablecerPregunta("¿Que es la Herencia en Programación orientado a objetos?");
            Mipregunta3.EstablecerRespuesta("Consiste en hacer uso de los atributos o métodos de una clase dentro de otra como si le perteneciera a este mismo");
            Mipregunta3.EstablecerIncorrecta(1, "Son similares a las variables de instancia, con la excepción de que los valores que guardan son los mismos para todos los objetos de una clase");
            Mipregunta3.EstablecerIncorrecta(2, "Es un nombre que identifica a una variable, a un método o función miembro, a una clase");
            Mipregunta3.EstablecerIncorrecta(3, "Define los elementos de dicho lenguaje y cómo se combinan para formar un programa");
            Mipregunta3.EstablecerIncorrecta(4, "Es una orden que se le da al programa para realizar una tarea específica");
            Mipregunta3.EstablecerIncorrecta(5, "Es un método especial de una clase que se llama automáticamente siempre que se declara un objeto de esa clase");

            //Pregunta #4
            Mipregunta4.EstablecerDificultad(5);
            Mipregunta4.EstablecerPregunta("¿Que es una Biblioteca de clases?");
            Mipregunta4.EstablecerRespuesta("Es un grupo de clases diseñada para su uso con otros programas");
            Mipregunta4.EstablecerIncorrecta(1, "Es un programa que transforma código fuente escrito en java a un código neutral a la plataforma conocido como java");
            Mipregunta4.EstablecerIncorrecta(2, "Es módulo ordenado de elementos para la computadora que se encuentran interrelacionados y que interactúan entre sí, en apoyo al usuario");
            Mipregunta4.EstablecerIncorrecta(3, "Es un lenguaje de programación de bajo nivel para los computadores, microprocesadores, microcontroladores y otros circuitos integrados programables");
            Mipregunta4.EstablecerIncorrecta(4, "Es un atributo de una parte de los datos que indica al ordenador (y/o al programador) algo sobre la clase de datos sobre los que se va a procesar");
            Mipregunta4.EstablecerIncorrecta(5, "Define los elementos de dicho lenguaje y cómo se combinan para formar un programa");

            //Pregunta #5
            Mipregunta5.EstablecerDificultad(5);
            Mipregunta5.EstablecerPregunta("¿Que es un intérprete?");
            Mipregunta5.EstablecerRespuesta("Es un programa informático capaz de analizar y ejecutar otros programas, escritos en un lenguaje de alto nivel.");
            Mipregunta5.EstablecerIncorrecta(1, "Es un programa que transforma código fuente escrito en java a un código neutral a la plataforma conocido como Java");
            Mipregunta5.EstablecerIncorrecta(2, "Es un entorno de desarrollo integrado libre, hecho principalmente para el lenguaje de programación Java");
            Mipregunta5.EstablecerIncorrecta(3, "Define los elementos de dicho lenguaje y cómo se combinan para formar un programa");
            Mipregunta5.EstablecerIncorrecta(4, "Es un atributo de una parte de los datos que indica al ordenador (y/o al programador) algo sobre la clase de datos sobre los que se va a procesar");
            Mipregunta5.EstablecerIncorrecta(5, "Es una orden que se le da al programa para realizar una tarea específica");

            #endregion

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
