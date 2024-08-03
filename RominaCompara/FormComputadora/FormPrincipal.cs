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
        List<Computadora> computadoras;//listas
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.computadoras = new List<Computadora>() //dar una nueva instancia a la lista (inicializar lista)
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
            //Crear una nueva instancia de la lista
            FormAltaComputadora formAltaComputadora = new FormAltaComputadora();
            formAltaComputadora.ShowDialog();//hacer que sea visible

            if (formAltaComputadora.DialogResult == DialogResult.OK)
            {
                computadoras.Add(formAltaComputadora.MiComputadora);

            }
            CargarDgv();
        }
        private void CargarDgv()
        {
            dgv_listaDeComputadoras.DataSource = null;
            dgv_listaDeComputadoras.DataSource = computadoras;

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow rows = dgv_listaDeComputadoras.SelectedRows[0];
            Computadora pc = new Computadora(
                Convert.ToInt32(rows.Cells["CapacidadDisco"].Value),
                (int)rows.Cells["MemoriaRam"].Value,
                rows.Cells["Procesador"].Value.ToString(),
                (string)rows.Cells["SistemaOperativo"].Value.ToString()
                );
            MessageBox.Show(pc.ToString());
        }
    }
}
