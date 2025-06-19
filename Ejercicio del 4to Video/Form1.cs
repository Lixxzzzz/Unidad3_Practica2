using Ejercicio_del_4to_Video.Controladores;
using Ejercicio_del_4to_Video.Entidades;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_del_4to_Video
{
    public partial class Form1 : Form
    {

        private AlumnoControlador AlumnoControlador = new AlumnoControlador();
        public Form1()
        {
            InitializeComponent();
        }
        // mostrar
        private void MostrarAlumnos(Alumnos[] alumnos)
        {
            dgAlumnos.DataSource = null; // Limpiar el DataGridView antes de asignar una nueva fuente de datos
            dgAlumnos.DataSource = alumnos; // Asignar la nueva fuente de datos
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validar campos de entrada
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            // Crear el alumno
            Alumnos alumno = new Alumnos()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Promedio = double.Parse(txtPromedio.Text)
            };

            // Registrar el alumno
            AlumnoControlador.Registrar(alumno);

            //mostrar los alumnos
            MostrarAlumnos(AlumnoControlador.ListarTodo());

            limpairCampos();

        }
        public void limpairCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPromedio.Clear();
            txtBuscar.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.");
                return;
            }
            // Obtener el código del alumno seleccionado
            string codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();


            // Eliminar fila seleccionada 
            AlumnoControlador.Eliminar(codigo);

            // Mostrar los alumnos
            MostrarAlumnos(AlumnoControlador.ListarTodo());
            // Limpiar los campos
            limpairCampos();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(AlumnoControlador.OrdenarPorPromedio());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar campo 
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un código para buscar.","AVISO");
                return;
            }
            // Buscar el alumno por código
            string codigo = txtBuscar.Text;

            //mostrar el alumno encontrado
            MostrarAlumnos(AlumnoControlador.BuscarPorCodigo(codigo));
        }
    }
}


