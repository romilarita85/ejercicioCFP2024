using BibliotecaDeAlumnos;
using Ejercicio_Objetos_2;
using FormAlumnos;
namespace FormAlumnos
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos;
        //alumnos:lista de objetos de tipo Alumno. Almacena los datos de los alumnos
        //que serán mostrados en la interfaz de usuario.
        public FormPrincipal() //Constructor FormPrincipal
        {
            InitializeComponent();
        }
        
        private void FormPrincipal_Load(object sender, EventArgs e)
        {//Este método se ejecuta cuando el formulario principal se carga.
        //Aquí se inicializa la lista de alumnos y se carga con algunos datos
        //iniciales utilizando el método ListaAlumnos() de la clase Alumno.
            this.alumnos = new List<Alumno>();
            this.alumnos = Alumno.ListaAlumnos();
            this.lst_alumnos.DataSource = alumnos;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {//Este método maneja el evento de hacer clic en el botón "Mostrar".
         //Se establece el origen de datos del control dgv_informacion con la lista de alumnos,
         //lo que mostrará los datos de los alumnos en un DataGridView (similar a un ecxel).
            this.CargarDgv();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {//Este método maneja el evento de hacer clic en el botón "Agregar".
            FormCrear formAlta = new FormCrear();//lamamos a la clase "FormCrear"
         //Crea una instancia del formulario FormCrear y lo muestra de forma modal.
        
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK && formAlta.MiAlumno is not null)
            { //Luego, verifica si el resultado del formulario es DialogResult.OK
             //y si se ha proporcionado un objeto válido de alumno.
                alumnos.Add(formAlta.MiAlumno);//En caso afirmativo, agrega el alumno a la lista, limpia y recarga
                //el origen de datos de lst_alumnos utilizando el método CargarListaAlumnos().
                CargarListaAlumnos();
                //lst_alumnos.DataSource = null;
                //lst_alumnos.DataSource = alumnos;
            }
        }
        private void CargarListaAlumnos()
        {//Este método se encarga de cargar la lista de alumnos en el control lst_alumnos.
            lst_alumnos.DataSource = null;
            lst_alumnos.DataSource = alumnos;
        }
        private void CargarDgv()
        {//Este método se encarga de cargar la lista de alumnos en el control dgv_informacion.
            dgv_informacion.DataSource = null;
            dgv_informacion.DataSource = alumnos;
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {//Este método maneja el evento de hacer clic en el botón "Evaluar".
         //Genera notas aleatorias para cada alumno en la lista.
            Random rand = new Random();
            foreach (Alumno item in alumnos)
            {
                item.NotaPrimerParcial = rand.Next(1,10);
                item.NotaSegundoParcial = rand.Next(1, 10);
            }

        }
    }
}
//formAlta.Show();
//Show(): Muestra el formulario de manera no modal, permitiendo la interacción con otros formularios
//y el código continúa ejecutándose después de mostrar el formulario.
//formAlta.ShowDialog();
//ShowDialog(): Muestra el formulario de manera modal, bloqueando la interacción con otros formularios
//hasta que el formulario modal se cierre y el código se bloquea hasta que el formulario se cierre.
//***********************************************************************************************

//private void btn_agregar_Click(object sender, EventArgs e)
//{
//    FormCrear formAlta = new FormCrear();//lamamos a la clase "FormCrear"
//    formAlta.ShowDialog();
//    DialogResult respuesta = MessageBox.Show("¿Desea agregar alumno a la lista?", "Agregar Alumno", MessageBoxButtons.OKCancel);

//    if (respuesta == DialogResult.OK)
//    {
//        alumnos.Add(formAlta.MiAlumno);
//        lst_alumnos.DataSource = null;
//        lst_alumnos.DataSource = alumnos;
//    }
//}