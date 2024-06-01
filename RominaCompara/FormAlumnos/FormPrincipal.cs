using BibliotecaDeAlumnos;
using Ejercicio_Objetos_2;
namespace FormAlumnos
{
    public partial class FormPrincipal : Form
    {
        private List<Alumno> alumnos;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.alumnos = new List<Alumno>();
            this.alumnos = Alumno.ListaAlumnos();
            this.lst_alumnos.DataSource = alumnos;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this.dgv_informacion.DataSource = alumnos;
        }
    }
}
