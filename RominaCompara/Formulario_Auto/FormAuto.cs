using PrimerEvaluacionAuto;
namespace Formulario_Auto
{
    public partial class FormAuto : Form
    {
        List<Auto> misAutos;
        //int cantidadDeAutos;
        public FormAuto()
        {
            InitializeComponent();
            
        }
        private void FormAuto_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.cmb_colores.Items.AddRange(Auto.ColoresValidos().ToArray());
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            string color = this.cmb_colores.Text;

            Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto
            misAutos.Add(miAuto);

            this.Limpiar();
        }
        private void Limpiar()
        {
            this.txt_marca.Text = string.Empty;
            this.txt_combustible.Text = string.Empty;
            this.cmb_colores.Text = string.Empty;
        }

       
    }
}
