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
    public partial class FormAltaComputadora : Form
    {
        Computadora miComputadora;//atributos
        public Computadora MiComputadora { get => miComputadora; } // propertie
        public FormAltaComputadora()
        {
            InitializeComponent();
        }

        private void FormAltaComputadora_Load(object sender, EventArgs e)
        {
            //this.cmb_procesadores.Items.AddRange(Computadora.ListadoDeProcesadores().ToArray());
            this.cmb_procesadores.DataSource = Computadora.ListadoDeProcesadores(); 
            //dar valor a la lista del comboBox
           
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Crear variables nuevas para darle valor a mi nuevo objeto
            int memoriaRam = (int)num_memoriaRam.Value;
            int capacidadDisco= (int)num_disco.Value;
            string procesador = cmb_procesadores.Text;
            string sistemaOperativo = string.Empty ;
            //List<string> programas = new List<string>();

            foreach (RadioButton rd in gpb_sitemasOperativos.Controls)
            {
                if (rd.Checked == true) 
                {
                    sistemaOperativo = rd.Text;
                    break;
                }
            }
            //Creacion de una nueva instancia de un objeto
            Computadora pc = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);
            
            foreach (CheckBox chk in gpb_programas.Controls)
            {
                if (chk.Checked) 
                {
                    pc.SetPrograma(chk.Text);

                }
            }
            this.miComputadora = pc;

            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
