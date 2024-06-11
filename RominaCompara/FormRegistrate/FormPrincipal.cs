using BibliotecaDeAlumnos;
namespace FormRegistrate
{
    public partial class FormPrincipal : Form
    {
        //el datagrew me va a generar una lista y necesito una lista(clase Ingresante)
        List<Ingresante>ingresantes; //lista para guardar ingresantes
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {//las listas se instancian en el evento load
            ingresantes = new List<Ingresante>();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {//Crear una nueva instancia del formulario de alta (FormAlta)
            FormAlta formAlta = new FormAlta();
         //invocar nueva instancia del formulario formAlta 
            formAlta.ShowDialog();

        }

    
    }
}
