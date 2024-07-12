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
            this.computadoras = new List<Computadora>() 
            { 
                new Computadora(240,16,"Pentium","Linux"),
                new Computadora(480,32,"Celeron","Android"),
                new Computadora(240,16,"Core 2","Unix"),
                new Computadora(480,32,"Intel Pentium","Window Server"),
                new Computadora(240,16,"Intel 386","Chrome Os"),
            };
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAltaComputadora formAltaComputadora = new FormAltaComputadora();
            formAltaComputadora.ShowDialog();

            if (formAltaComputadora.DialogResult == DialogResult.OK) 
            {
                computadoras.Add(formAltaComputadora.MiComputadora);
                
            }
            CargarDgv();
        }
        private void CargarDgv() 
        {
            dgb_listaDeComputadoras.DataSource = null;
            dgb_listaDeComputadoras.DataSource = computadoras;
        
        }
    }
}
