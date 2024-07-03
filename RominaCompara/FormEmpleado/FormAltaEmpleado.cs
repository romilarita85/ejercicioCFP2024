using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeEmpleados1;

namespace FormEmpleado
{
    public partial class FormAltaEmpleado : Form
    {
        Empleado empleado;//ATRIBUTO

        public Empleado Empleado { get => empleado; }//propertie
        public FormAltaEmpleado()
        {
            InitializeComponent();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            double salario = (double)num_salario.Value;
            string departamento = string.Empty;//RadioButton
            int antiguedad = (int)num_antiguedad.Value;

            foreach (RadioButton rd in gpb_departamentos.Controls)//Sacar algo del tipo radioButton en cada vuelta
            {//Saco algo del tipo radioButton en la coleccion del groupbox_genero por medio del operador punto
             //accedo a propiedad Controls
                if (rd.Checked == true)//para verificar el componente (rd)q acabamps de sacar-> ver en q estado esta
                {//si es true ->fue chequeado
                    departamento = rd.Text;
                    break;
                }
            }
            empleado = new Empleado(nombre, salario, departamento, antiguedad);
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
