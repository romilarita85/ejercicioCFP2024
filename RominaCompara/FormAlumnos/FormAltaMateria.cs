using BibliotecaDeAlumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumnos
{
    public partial class FormAltaMateria : Form
    {
        //ATRIBUTO
        private Materia miMateria;
        public FormAltaMateria() //CONSTRUCTOR
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text) && txt_nombre.Text is not null && txt_nombre.Text != "")
            {
                this.miMateria = new Materia(txt_nombre.Text);//crear nueva instancia de cada materia
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //PROPERTIE: para saber a quien llamo
        public Materia MiMateria
        {
            get
            {
                return this.miMateria;//se retorna el atributo miMateria
            }
        }
    }
}
