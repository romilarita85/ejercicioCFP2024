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
        private void btn_agregar_Click(object sender, EventArgs e)//Evento-(me comunica con FormAlta)
        {//Crear una nueva instancia del formulario de alta (formAlta)
            FormAlta formAlta = new FormAlta();
         //invocar nueva instancia del formulario formAlta 
            formAlta.ShowDialog();
           
            if (formAlta.DialogResult == DialogResult.OK)//Evaluar q respuesta de la propertie formAlta
            {//si la respuesta fue ok agrego nuevo ingresante en mi lista ingresantes
                ingresantes.Add(formAlta.Ingresante);//uso protertie Ingresante creada en formAlta 
                this.CargarIngresantesDgv();
                MessageBox.Show($"Ingresaste un nuevo ingresante a la lista","Informacion");
            } 
            
        }
        private void CargarIngresantesDgv()
        {//Este método se encarga de cargar la lista de lapiceras del Dgv
            dgv_ingresantes.DataSource = null;//nulearla por default-evita repeticiones
            dgv_ingresantes.DataSource = ingresantes;//Cargar mi Data grew con la lista q acabo de ir incrementando
        }
    }
}
