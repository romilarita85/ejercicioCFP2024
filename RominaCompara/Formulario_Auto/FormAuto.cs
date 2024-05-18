using PrimerEvaluacionAuto;
namespace Formulario_Auto
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }
        private void btn_Crear_Click(object sender, EventArgs e) 
        {
            string marca = this.txt_marca.Text;
            string cantCombustible = this.txt_combustible.Text;
            string color = this.txt_color.Text;
            
            Auto miAuto = new Auto("Toyota", 65, Color.Coral);
        }
    }
}
