using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeLapiceras;

namespace Form_Lapicera2
{
    public partial class FormAltaLapicera : Form
    {
        Lapicera lapicera;
        public FormAltaLapicera()
        {
            InitializeComponent();
        }
        public Lapicera Lapicera { get => lapicera; }

        private void FormAltaLapicera_Load(object sender, EventArgs e)
        {
            this.cmb_colores.DataSource = Lapicera.ColoresValidos();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Color color = (Color)cmb_colores.SelectedItem;
            double precio = (double)num_precio.Value;
            string marca = string.Empty;
            
            foreach (RadioButton rd in gpb_marcas.Controls)//Sacar algo del tipo radioButton en cada vuelta
            {
                //Saco algo del tipo radioButton en la coleccion del groupbox_genero por medio del operador punto accedo a propiedad Controls
                if (rd.Checked == true)//para verificar el componente (rd)q acabamps de sacar-> ver en q estado esta
                {//si es true ->fue chequeado
                    marca = rd.Text;
                    break;
                }
            }

            DialogResult = DialogResult.OK;
            
            lapicera = new Lapicera(color, precio, marca); //crear lapicera//agrega el objeto miAuto a la lista llamada misAutos (lo agrega o no)

    
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
