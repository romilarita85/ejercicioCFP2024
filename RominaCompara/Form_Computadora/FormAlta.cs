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
    public partial class FormAlta : Form
    {
        Computadora miComputadora;
        public Computadora MiComputadora
        {
            get
            {
                return this.miComputadora;
            }
        }
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.cmb_procesadores.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Crear variables nuevas para darle valor a mi nuevo objeto
            int memoriaRam = (int)this.num_memoriaRam.Value;
            int capacidadDisco = (int)this.num_disco.Value;
            string procesador = this.cmb_procesadores.Text;
            string sistemaOperativo = string.Empty;

            foreach (RadioButton componente in gpb_sitemasOperativos.Controls)
            {
                if (componente.Checked == true)
                {
                    sistemaOperativo = componente.Text;
                    break;
                }
            }
            //Creacion de una nueva instancia de un objeto
            this.miComputadora = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);

            foreach (CheckBox chk in gpb_programas.Controls)
            {
                if (chk.Checked)
                {
                    this.miComputadora.SetPrograma(chk.Text);

                }
            }
            if (memoriaRam != 0 && capacidadDisco != 0 && !string.IsNullOrEmpty(procesador)&& !string.IsNullOrEmpty(sistemaOperativo) && miComputadora is not null && miComputadora.GetProgramas().Count > 0)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
