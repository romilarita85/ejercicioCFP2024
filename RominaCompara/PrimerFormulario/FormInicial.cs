using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrimerFormulario
{
    public partial class FormInicial : Form
    {

        string nombre;
        string apellido;
        string password;
        public FormInicial()
        {
            InitializeComponent();

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            this.nombre = text_nombre.Text;
            this.apellido = text_apellido.Text;
            this.password = text_password.Text;
            lst_salida.Items.Add($"El nombre ingresado es: {this.nombre}");
            lst_salida.Items.Add($"El apellido ingresado es: {this.apellido}");
            lst_salida.Items.Add($"La contraseña ingresada es: {this.password}");

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            text_nombre.Clear();
            text_apellido.Clear();
            text_password.Clear();
        }
    }
}
