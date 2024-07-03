using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeAlumnos;
namespace FormAlumnos2
{
    public partial class FormAltaMateria : Form
    {
        private Materia miMateria;
        public FormAltaMateria()
        {
            InitializeComponent();
        }

        public Materia MiMateria { get => miMateria; set => miMateria = value; }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //miMateria = new Materia(txt_nombre.Text);
            //DialogResult = DialogResult.OK;
            if (!string.IsNullOrEmpty(txt_nombre.Text) && txt_nombre.Text is not null && txt_nombre.Text != "")
            {
                this.miMateria = new Materia(txt_nombre.Text);//crear nueva instancia de cada materia
                this.DialogResult = DialogResult.OK;
            }
            else //si esta vacia va a devolver
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
