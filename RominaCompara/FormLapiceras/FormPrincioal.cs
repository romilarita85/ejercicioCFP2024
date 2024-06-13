using BibliotecaDeLapiceras;
namespace FormLapicera
{
    public partial class FormPrincipal : Form
    {
        List<Lapicera> lapiceras;//lista para guardar lapiceras
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lapiceras = new List<Lapicera>();//instanciar lista
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();//crear nueva instancia del formAlta
            
            formAlta.ShowDialog();//invocar nueva instancia del formulario formAlta 

            if (formAlta.DialogResult == DialogResult.OK)//Evaluar q respuesta de la propertie formAlta
            {//si la respuesta fue ok agrego nuevo ingresante en mi lista ingresantes
                
               
            }
        }
    }
}
