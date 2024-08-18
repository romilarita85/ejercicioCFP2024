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
                { //rb.Text.ToLower(): Convierte el texto del RadioButton a minúsculas.
                  //miComputadora.SistemaOperativo.ToLower(): Convierte el texto del sistema operativo
                  //de la computadora a minúsculas.
                  //==: Compara las dos cadenas resultantes en minúsculas para determinar si son iguales.
                    rb.Checked = true;// Marca el RadioButton
                    break;
                }
            }
            foreach (CheckBox chk in gpb_programas.Controls)
            {
                foreach (string prog in miComputadora.GetProgramas())
                {//representa la iteración sobre una colección de programas que se obtiene
                 //del método GetProgramas() de miComputadora. Este método parece devolver una
                 //colección de nombres de programas que se usarán para comparar con los CheckBox en el GroupBox.
                    if (chk.Text.ToLower() == prog.ToLower())
                    {// chk.Text.ToLower(): Convierte el texto del CheckBox(chk.Text) a minúsculas.
                   // Esto asegura que la comparación sea insensible al caso, independientemente de si el
                   // texto original tiene mayúsculas o minúsculas.
                    //prog.ToLower(): Convierte el nombre del programa(prog) a minúsculas.
                    //==: Compara las dos cadenas convertidas a minúsculas.Si ambas cadenas coinciden,
                    //la condición se evalúa como true.
  
                        chk.Checked = true;
                        break;
                    }
                }


            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int capacidadDisco;
            int memoriaRam;
            string procesador = string.Empty;
            string sistemaOperativo = string.Empty;
            int numeroDeSerie = (int)this.num_DeSerie.Value;;

            memoriaRam = (int)this.num_memoriaRam.Value;
            capacidadDisco = (int)this.num_disco.Value;
            procesador = this.cmb_procesadores.Text;
            

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

            foreach (CheckBox chk in this.gpb_programas.Controls)
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
