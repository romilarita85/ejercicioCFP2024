using BibliotecaDeAlumnos2;
namespace FormRegistrate_2
{
    public partial class FormPrincipal : Form
    {
        List<Ingresante> ingresantes;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ingresantes = new List<Ingresante>();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAllta = new FormAlta();
            formAllta.ShowDialog();
          
            if (formAllta.DialogResult == DialogResult.OK)//Evaluar q respuesta de la propertie formAlta
            {//si la respuesta fue ok agrego nuevo ingresante en mi lista ingresantes
                ingresantes.Add(formAllta.NuevoIngresante);//uso protertie Ingresante creada en formAlta 
                this.CargarIngresantesDgv();
                MessageBox.Show($"Ingresaste un nuevo ingresante a la lista", "Informacion");
            }
        }
        private void CargarIngresantesDgv() 
        {
            dgv_listaIngresantes.DataSource = null;
            dgv_listaIngresantes.DataSource = ingresantes;
        }


    }
}
