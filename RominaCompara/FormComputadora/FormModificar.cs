using BibliotecaDeComputadoras;
using FormComputadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComputadora
{
    public partial class FormModificar : Form
    {
        private Computadora miPc;

        public Computadora MiPc
        {
            get { return miPc; }
        }
       
        public FormModificar()
        {
            InitializeComponent();
        }
        //3-Parametro del constructor parametrizado
        public FormModificar(Computadora pc):this()
        {
            this.miPc = pc;

        }
        private void FormModificar_Load(object sender, EventArgs e)
        {//Cargar componentes del formulario por medio de las properties(de la clase Computadora)
            cmb_procesadores.Text = miPc.Procesador;
            num_memoriaRam.Value = miPc.MemoriaRam;
            num_disco.Value = miPc.CapacidadDisco;

            foreach (RadioButton rb in gpb_programas.Controls)
            {
                if (rb.Text.ToLower() == miPc.SistemaOperativo.ToLower())
                {
                    rb.Checked = true;
                    break;
                }
            }
            foreach (CheckBox chk in gpb_programas.Controls)
            {
                foreach (string prg in miPc.GetProgramas())
                {
                    if (chk.Text.ToLower() == prg.ToLower())
                    {
                        chk.Checked = true;
                        break;
                    }
                }
            }

        }
    }
}
//////Recibir computadota 3 formas:
////1-Por medio de Set
//public Computadora MiPc 
//{
//    set { miPc = value; } 
//}
////2-Usando Propertie
//public void SetMiPc(Computadora pc) 
//{
//    this.miPc = pc;
//}
///*********************
//public FormModificar()
//{
//    InitializeComponent();
//}
//*************************
////3-Parametro del constructor parametrizado
//public FormModificar(Computadora pc):this()
//        {
//    this.miPc = pc;

//}