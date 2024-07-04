using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeComputadoras;

namespace FormComputadora
{
    public partial class FormPrincipal : Form
    {
        List<Computadora> computadoras;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            computadoras = new List<Computadora>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAltaComputadora formAltaComputadora = new FormAltaComputadora();
            formAltaComputadora.ShowDialog();

            if (formAltaComputadora.DialogResult == DialogResult.OK) 
            {
                computadoras.Add(formAltaComputadora.MiComputadora);
                CargarDgv();
            }

        }
        private void CargarDgv() 
        {
            dgb_listaDeComputadoras.DataSource = null;
            dgb_listaDeComputadoras.DataSource = computadoras;
        
        }
    }
}
