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
namespace Form_Computadora
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
            this.computadoras = new List<Computadora>();
            this.computadoras = new List<Computadora>() //dar una nueva instancia a la lista (inicializar lista)
            {
                new Computadora(240,16,"Pentium","Linux"),
                new Computadora(480,32,"Celeron","Android"),
                new Computadora(240,16,"Core 2","Unix"),
                new Computadora(480,32,"Intel Pentium","Window Server"),
                new Computadora(240,16,"Intel 386","Chrome Os"),
            };
            dgv_listaComputadoras.DataSource = null;
            dgv_listaComputadoras.DataSource = computadoras;   
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Crear una nueva instancia de la lista
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();//hacer que sea visible

            if (formAlta.DialogResult == DialogResult.OK)
            {
                this.computadoras.Add(formAlta.MiComputadora);

            }
            CargarDgv();
        }
       
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Computadora pcEditar = (Computadora)dgv_listaComputadoras.CurrentRow.DataBoundItem as Computadora;
            FormModificar modificar = new FormModificar(pcEditar);
            modificar.ShowDialog();

            if (modificar.DialogResult == DialogResult.OK) 
            {
                int index = this.computadoras.FindIndex(pcBuscar => pcBuscar.NumeroDeSerie == modificar.MiComputadora.NumeroDeSerie);
                this.computadoras[index] = modificar.MiComputadora;
                CargarDgv();
            }
        }
        private void CargarDgv()
        {
            dgv_listaComputadoras.DataSource = null;
            dgv_listaComputadoras.DataSource = computadoras;

        }
    }

}
