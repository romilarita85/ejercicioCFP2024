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
        Computadora computadora;
        public Computadora MiComputadora { get => computadora; set => computadora = value; } // propertie
        public FormAltaComputadora()
        {
            InitializeComponent();
        }

        private void FormAltaComputadora_Load(object sender, EventArgs e)
        {
            cmb_procesadores.Items.AddRange(Computadora.ListadoDeProcesadores().ToArray());

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int memoriaRam = (int)num_memoriaRam.Value;
            int capacidadDisco= (int)num_disco.Value;
            string procesador = cmb_procesadores.Text;
            string sistemaOperativo = string.Empty ;
            List<string> programas = new List<string>();

            foreach (RadioButton rd in gpb_sitemasOperativos.Controls)
            {
                if (rd.Checked == true) 
                {
                    sistemaOperativo = rd.Text;
                    break;

                }

            }

            foreach (CheckBox chk in gpb_programas.Controls)
            {
                if (chk.Checked == true) 
                {
                    programas.Add(chk.Text);
                    break;

                }
            }
            computadora = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo);
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
