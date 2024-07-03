using BibliotecaDeAlumnos;
namespace FormAlumnos2
{
    public partial class FormPrincipal : Form
    {

        private List<Alumno> alumnos;
        private List<Materia> materias;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            alumnos = new List<Alumno>();
            materias = new List<Materia>();
            alumnos = new Alumno.ListaAlumnos();
            lst_alumnos.DataSource = alumnos;
        }
        private void btn_agregarAlumno_Click(object sender, EventArgs e)
        {
            FormAltaAlumno formAltaAlumno = new  FormAltaAlumno();
            formAltaAlumno.ShowDialog();
           
            if (formAltaAlumno.DialogResult == DialogResult.OK && formAltaAlumno.MiNuevoAlumno is not null) 
            {
                alumnos.Add(formAltaAlumno.MiNuevoAlumno);
                CargarListaAlumnos();
            }
        }

        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            FormAltaMateria formAltaMateria = new FormAltaMateria();
            formAltaMateria.ShowDialog();

            if (formAltaMateria.DialogResult == DialogResult.OK)
            {
                materias.Add(formAltaMateria.MiMateria);
                CargarListaMaterias();
            }
        }

        private void btn_crearEstadoAcad_Click(object sender, EventArgs e)
        {
            Alumno alumno = alumnos[0];//primer alumno
            List<Materia> lista = materias; //listado de materias
            string carrera = "Trayecto programacion";//pasar la carrera hardcodeada
            //crear nueva instancia del formulario con esos datos
            FormEstadoAcademico estadoAcademico = new FormEstadoAcademico(alumno,lista,carrera);

            estadoAcademico.ShowDialog();
        }
        private void CargarListaAlumnos() 
        {
            lst_alumnos.DataSource = null;
            lst_alumnos.DataSource = alumnos;
        
        }
        private void CargarListaMaterias()
        {
            lst_materias.DataSource = null;
            lst_materias.DataSource = materias;

        }
        private void btn_evaluar_Click(object sender, EventArgs e)
        {//Este método maneja el evento de hacer clic en el botón "Evaluar".
         //Genera notas aleatorias para cada alumno en la lista.
            Random rand = new Random();
        }
    }
}
