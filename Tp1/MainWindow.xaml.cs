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
using Entidades;

namespace Tp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Alumno> Alumnos;
        int cntId = 0;
        public MainWindow()
        {
            InitializeComponent();

            //Seteo los valores de CbxCurso
            CbxCurso.ItemsSource = Enum.GetNames(typeof(Curso));
            CbxCurso.SelectedIndex = 0;

            Alumnos = new List<Alumno>();
            
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Alumno alumno = new Alumno();
            bool alumnoValido = true;

            if (TbxNombre.Text == "" || TbxNombre == null)
            {
                alumnoValido = false;
                MessageBox.Show("¡Nombre mal!");
            }
            else
            {
                alumno.SetNombre(TbxNombre.Text);
            }
            if (TbxApellido.Text == "" || TbxApellido == null)
            {
                alumnoValido = false;
                MessageBox.Show("¡Apellido mal!");
            }
            else
            {
                alumno.SetApellido(TbxApellido.Text);
            }

            alumno.SetCurso((Curso)CbxCurso.SelectedIndex);
            alumno.InicializarId(cntId++);
            //MessageBox.Show(alumnoValido.ToString());
            if (alumnoValido)
            {
                Alumnos.Add(alumno);
                LvAlumnos.Items.Add(alumno);
            }
            
        }

    }
}
