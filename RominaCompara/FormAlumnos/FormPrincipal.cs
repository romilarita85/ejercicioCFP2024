using BibliotecaDeAlumnos;
using Ejercicio_Objetos_2;
using FormAlumnos;
namespace FormAlumnos
{
    public partial class FormPrincipal : Form
    {
        //Atributos:
        private List<Alumno> alumnos;
        private List<Materia> materias;
        //alumnos:lista de objetos de tipo Alumno. Almacena los datos de los alumnos
        //que ser�n mostrados en la interfaz de usuario.
        public FormPrincipal() //Constructor FormPrincipal
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)//Evento Load
        {//Este m�todo se ejecuta cuando el formulario principal se carga por primera vez.
            this.alumnos = new List<Alumno>();//inicializar lista de alumnos
            this.materias = new List<Materia>();//inicializar lista de materias
            this.alumnos = Alumno.ListaAlumnos();//Llamar al metodo listaAlumnos() de la clase alumno para cargar
                                                 //algunos datos iniciales en la lista de alumnos
            this.lst_alumnos.DataSource = alumnos;//Establecer la lista de alumnos como origen de datos
                                                  //del control lst_alumnos
        }//Todas la listas tienen que estar inicializadas en el Load

        private void btn_agregar_Click(object sender, EventArgs e)
        {//Este m�todo maneja el evento de hacer clic en el bot�n "Agregar".
            FormCrear formAlta = new FormCrear();//lamamos a la clase "FormCrear"
                             //Crea una instancia del formulario FormCrear y lo muestra de forma modal.

            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK && formAlta.MiAlumno is not null)
            { //Luego, verifica si el resultado del formulario es DialogResult.OK
              //y si se ha proporcionado un objeto v�lido de alumno.
                alumnos.Add(formAlta.MiAlumno);//En caso afirmativo, agrega el alumno a la lista, limpia y recarga
                //el origen de datos de lst_alumnos utilizando el m�todo CargarListaAlumnos().
                CargarListaAlumnos();
            }
        }
        private void CargarListaAlumnos()
        {//Este m�todo se encarga de cargar la lista de alumnos en el control lst_alumnos.
            lst_alumnos.DataSource = null;
            lst_alumnos.DataSource = alumnos;
        }

        private void CargarListaMaterias()
        {//Este m�todo se encarga de cargar la lista de materias en el control lst_materias.
            lst_materias.DataSource = null;//establece el origen de datos del control ListBox lst_materias como null
                                          //,lo que borra cualquier origen de datos previamente asignado al control.
            lst_materias.DataSource = materias;//establece el origen de datos del control ListBox lst_materias
//como una lista de materias, definida en alg�n lugar de tu c�digo.
//Significa que las materias contenidas en la lista materias se mostrar�n en el control ListBox.
        }

        private void btn_evaluar_Click(object sender, EventArgs e)
        {//Este m�todo maneja el evento de hacer clic en el bot�n "Evaluar".
         //Genera notas aleatorias para cada alumno en la lista.
            Random rand = new Random();
        }
        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            FormAltaMateria formAltaMateria = new FormAltaMateria();//Crear una nueva instancia del
                                                                    //formulario secundario FormAltaMateria
            formAltaMateria.ShowDialog();// Mostrar el formulario secundario de forma modal
            //Despu�s de cerrar el formulario secundario, verificar si se ha confirmado la acci�n
            if (formAltaMateria.DialogResult == DialogResult.OK)
            {//Comprobar si el resultado del formulario (DialogResult) es OK.
                materias.Add(formAltaMateria.MiMateria);//Si se ha confirmado la acci�n,se a�ade la materia
              //proporcionada por el formulario (formAltaMateria.MiMateria) a la lista materias.
                CargarListaMaterias();//Luego, se llama al m�todo CargarListaMaterias()
                                      //para actualizar la lista de materias en la interfaz de usuario.
            }
        }

        private void btn_estadoAcademico_Click(object sender, EventArgs e)
        {
            Alumno alumno = alumnos[0];
            List<Materia> lista = materias;
            string carrera = "Trayecto programacion";
            ForEstadoAcademico estadoAcademico = new ForEstadoAcademico();    
        }
    }
}
//formAlta.Show();
//Show(): Muestra el formulario de manera no modal, permitiendo la interacci�n con otros formularios
//y el c�digo contin�a ejecut�ndose despu�s de mostrar el formulario.
//formAlta.ShowDialog();
//ShowDialog(): Muestra el formulario de manera modal, bloqueando la interacci�n con otros formularios
//hasta que el formulario modal se cierre y el c�digo se bloquea hasta que el formulario se cierre.
//DialogResult:Despu�s de mostrar el formulario con ShowDialog(), puedes obtener el resultado utilizando
//la propiedad DialogResult del formulario secundario. Puedes realizar acciones adicionales
//dependiendo del resultado devuelto por el formulario.
//***********************************************************************************************

//private void btn_agregar_Click(object sender, EventArgs e)
//{
//    FormCrear formAlta = new FormCrear();//llamamos a la clase "FormCrear"
//    formAlta.ShowDialog();
//    DialogResult respuesta = MessageBox.Show("�Desea agregar alumno a la lista?", "Agregar Alumno", MessageBoxButtons.OKCancel);

//    if (respuesta == DialogResult.OK)
//    {
//        alumnos.Add(formAlta.MiAlumno);
//        lst_alumnos.DataSource = null;
//        lst_alumnos.DataSource = alumnos;
//    }
//}
//********************************************************************************************************+
//using BibliotecaDeAlumnos;
//using Ejercicio_Objetos_2;
//using FormAlumnos;
//namespace FormAlumnos
//{
//    public partial class FormPrincipal : Form
//    {
//        private List<Alumno> alumnos;
//        //alumnos:lista de objetos de tipo Alumno. Almacena los datos de los alumnos
//        //que ser�n mostrados en la interfaz de usuario.
//        public FormPrincipal() //Constructor FormPrincipal
//        {
//            InitializeComponent();
//        }

//        private void FormPrincipal_Load(object sender, EventArgs e)
//        {//Este m�todo se ejecuta cuando el formulario principal se carga.
//         //Aqu� se inicializa la lista de alumnos y se carga con algunos datos
//         //iniciales utilizando el m�todo ListaAlumnos() de la clase Alumno.
//            this.alumnos = new List<Alumno>();
//            this.alumnos = Alumno.ListaAlumnos();
//            this.lst_alumnos.DataSource = alumnos;
//        }

//        private void btn_mostrar_Click(object sender, EventArgs e)
//        {//Este m�todo maneja el evento de hacer clic en el bot�n "Mostrar".
//         //Se establece el origen de datos del control dgv_informacion con la lista de alumnos,
//         //lo que mostrar� los datos de los alumnos en un DataGridView (similar a un ecxel).
//            this.CargarDgv();
//        }

//        private void btn_agregar_Click(object sender, EventArgs e)
//        {//Este m�todo maneja el evento de hacer clic en el bot�n "Agregar".
//            FormCrear formAlta = new FormCrear();//lamamos a la clase "FormCrear"
//                                                 //Crea una instancia del formulario FormCrear y lo muestra de forma modal.

//            formAlta.ShowDialog();

//            if (formAlta.DialogResult == DialogResult.OK && formAlta.MiAlumno is not null)
//            { //Luego, verifica si el resultado del formulario es DialogResult.OK
//              //y si se ha proporcionado un objeto v�lido de alumno.
//                alumnos.Add(formAlta.MiAlumno);//En caso afirmativo, agrega el alumno a la lista, limpia y recarga
//                //el origen de datos de lst_alumnos utilizando el m�todo CargarListaAlumnos().
//                CargarListaAlumnos();
//                //lst_alumnos.DataSource = null;
//                //lst_alumnos.DataSource = alumnos;
//            }
//        }
//        private void CargarListaAlumnos()
//        {//Este m�todo se encarga de cargar la lista de alumnos en el control lst_alumnos.
//            lst_alumnos.DataSource = null;
//            lst_alumnos.DataSource = alumnos;
//        }
//        private void CargarDgv()
//        {//Este m�todo se encarga de cargar la lista de alumnos en el control dgv_informacion.
//            dgv_informacion.DataSource = null;
//            dgv_informacion.DataSource = alumnos;
//        }

//        private void btn_evaluar_Click(object sender, EventArgs e)
//        {//Este m�todo maneja el evento de hacer clic en el bot�n "Evaluar".
//         //Genera notas aleatorias para cada alumno en la lista.
//            Random rand = new Random();
//            foreach (Alumno item in alumnos)
//            {
//                item.NotaPrimerParcial = rand.Next(1, 10);
//                item.NotaSegundoParcial = rand.Next(1, 10);
//            }

//        }
//    }
//}