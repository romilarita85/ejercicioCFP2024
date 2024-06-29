using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeEmpleados;

namespace FormEmpleado
{
    public partial class FormAltaEmpleado : Form
    {
        Empleado empleado;//ATRIBUTO

        public Empleado Empleado { get => empleado; }
        public FormAltaEmpleado()
        {
            InitializeComponent();
        }

        private void FormAltaEmpleado_Load(object sender, EventArgs e)
        {
            lst_departamentos.DataSource = new List<string>()
            {
                "Contabilidad","Finanzas","Sistemas","Administracion","Auditoria","Ventas"
            };

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            //double salario = num_salario.Text;
            string departamento = lst_departamentos.Text;
            //int antiguedad = int.Empty;
        }
    }
}
