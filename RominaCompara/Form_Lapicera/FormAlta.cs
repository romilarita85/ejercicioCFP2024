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
            
            
            DialogResult = DialogResult.OK;

            if (!string.IsNullOrEmpty(txt_marca.Text) && txt_marca.Text is not null && txt_marca.Text != "")
            {
                MessageBox.Show("¿Decea ingresar lapicera a la lista?", "Alta lapicera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lapicera = new Lapicera(color, precio, marca); //crear lapicera

            }
            else 
            { 
                MessageBox.Show("Por favor, ingrese una marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución del método si la validación falla
            }

            // Si pasa la validación, continuar con el proceso
            // Por ejemplo, guardar el nombre en una variable o hacer algo más
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
       

    }
}
