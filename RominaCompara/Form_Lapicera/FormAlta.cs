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
namespace Form_Lapicera
{
    public partial class FormAlta : Form
    {
        Lapicera lapicera;
        public Lapicera Lapicera { get => lapicera; } //propertie

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            //lapicera = new List<Lapicera>();
            this.cmb_colores.DataSource = Lapicera.ColoresValidos();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Color color =(Color)cmb_colores.SelectedItem;
            double precio = (double)num_precio.Value;
            string marca = txt_marca.Text;
            

            lapicera = new Lapicera(color,precio,marca); //crear lapicera
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

 
    }
}
