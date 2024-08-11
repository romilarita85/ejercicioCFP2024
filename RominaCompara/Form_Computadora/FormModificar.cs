﻿using BibliotecaDeComputadoras;
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
            cmb_procesadores.Text = miComputadora.Procesador;
            num_memoriaRam.Value = miComputadora.MemoriaRam;
            num_disco.Value = miComputadora.CapacidadDisco;
            num_DeSerie.Value = miComputadora.NumeroDeSerie;

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
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
