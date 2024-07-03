using LibreriaDeEmpleados1;
namespace FormEmpleado
{
    public partial class FormPrincipal : Form
    {
        List<Empleado> empleados;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            empleados = new List<Empleado>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado formAltaEmpleado = new FormAltaEmpleado();//Crea instancia del formulario secundario
            
            formAltaEmpleado.ShowDialog();

            if (formAltaEmpleado.DialogResult == DialogResult.OK && formAltaEmpleado.Empleado is not null) 
            {
                empleados.Add(formAltaEmpleado.Empleado);//uso protertie Empleado creada en formAlta 
                this.CargarDgbEmpleados();

            }
        }
        private void CargarDgbEmpleados() 
        {
            dgv_listaDeEmpleados.DataSource = null;
            dgv_listaDeEmpleados.DataSource = empleados;
        }
    }
}
