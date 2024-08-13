using BibliotecaDeComputadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Computadora
{
    public partial class FormModificar : Form
    {
        private Computadora miComputadora;
        public Computadora MiComputadora
        {
            get
            {
                return this.miComputadora;
            }
        }
        public FormModificar()
        {
            InitializeComponent();
        }
        //3-Parametro del constructor parametrizado
        public FormModificar(Computadora pc) : this()
        {
            this.miComputadora = pc;

        }
        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmb_procesadores.DataSource = Computadora.ListadoDeProcesadores();
            //Cargar componentes del formulario por medio de las properties(de la clase Computadora)
           
            cmb_procesadores.Text =this.miComputadora.Procesador;
            num_memoriaRam.Value = this.miComputadora.MemoriaRam;
            num_disco.Value = this.miComputadora.CapacidadDisco;
            num_DeSerie.Value = this.miComputadora.NumeroDeSerie;

            foreach (RadioButton rb in gpb_sitemasOperativos.Controls)
            {
                if (rb.Text.ToLower() == miComputadora.SistemaOperativo.ToLower())
                {
                    rb.Checked = true;
                    break;
                }
            }
            foreach (CheckBox chk in gpb_programas.Controls)
            {
                foreach (string prog in miComputadora.GetProgramas())
                {
                    if (chk.Text.ToLower() == prog.ToLower())
                    {
                        chk.Checked = true;
                        break;
                    }
                }
            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int numeroDeSerie = (int)this.num_DeSerie.Value;
            int memoriaRam = (int)this.num_memoriaRam.Value;
            int capacidadDisco = (int)this.num_disco.Value;
            string procesador = this.cmb_procesadores.Text;
            string sistemaOperativo = string.Empty;

            foreach (RadioButton componente in gpb_sitemasOperativos.Controls)
            {
                if (componente.Checked)
                {
                    sistemaOperativo = componente.Text;
                    break;
                }
            }
            //Creacion de una nueva instancia de un objeto
            this.miComputadora = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo,numeroDeSerie);

            foreach (CheckBox chk in gpb_programas.Controls)
            {
                if (chk.Checked)
                {
                    this.miComputadora.SetPrograma(chk.Text);

                }
            }
            if (memoriaRam != 0 && capacidadDisco != 0 && !string.IsNullOrEmpty(procesador) && !string.IsNullOrEmpty(sistemaOperativo) && miComputadora is not null && miComputadora.GetProgramas().Count > 0)
            {
                DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Debe ingresar por lo menos 1 valor de cada item","Faltan datos",MessageBoxButtons.YesNo);
            }
            
        }
    }
}
