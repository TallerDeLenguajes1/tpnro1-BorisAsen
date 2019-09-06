using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP1_Asen_Boris_Yamir
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Crear lista de alumnos
        List<Alumno> Atletismo = new List<Alumno>();
        List<Alumno> Voley = new List<Alumno>();
        List<Alumno> Futbol = new List<Alumno>();

        //Tomar los datos del textbox cada vez que presione el boton
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            //Tomar el contenido del text box
            int id = Convert.ToInt16(txbId.Text);
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            string curso = cboCurso.Text;

            //Creo nuevo alumno y cargo los valores tomados
            Alumno nuevoAlumno = new Alumno();
            nuevoAlumno.id = id;
            nuevoAlumno.nombre = nombre;
            nuevoAlumno.apellido = apellido;
            Materia nuevoCurso= new Materia();
            nuevoCurso.tema = curso;
            nuevoCurso.profesor = null;
            nuevoAlumno.curso = nuevoCurso;

            //Guardo el nuevo alumno en la lista
            switch (curso)
            {
                case "Atletismo":
                    Atletismo.Add(nuevoAlumno);
                    lbxAtletismo.Items.Add(nuevoAlumno);
                    break;
                case "Voley":
                    Voley.Add(nuevoAlumno);
                    lbxVoley.Items.Add(nuevoAlumno);
                    break;
                case "Futbol":
                    Futbol.Add(nuevoAlumno);
                    lbxFutbol.Items.Add(nuevoAlumno);
                    break;

            }

            //Agregar selector de path para elegir donde generar los archivos csv
            //Hacer boton de exportar
            //Dentro del evento del boton enviar

            txblAteltismo.Text = "";
            txblVoley.Text = "";
            txblFutbol.Text = "";

        }

        private void btnExportarAtletismo_Click(object sender, RoutedEventArgs e)
        {
            HelperDeArchivos.CargarArchivo(Atletismo, "Atletismo.csv");
            txblAteltismo.Text = "Archivo csv guardado";
        }

        private void btnExportarVoley_Click(object sender, RoutedEventArgs e)
        {
            HelperDeArchivos.CargarArchivo(Voley, "Voley.csv");
            txblVoley.Text = "Archivo csv guardado";
        }

        private void btnExportarFutbol_Click(object sender, RoutedEventArgs e)
        {
            HelperDeArchivos.CargarArchivo(Futbol, "Futbol.csv");
            txblFutbol.Text = "Archivo csv guardado";
        }
    }
}