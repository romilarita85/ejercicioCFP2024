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
    public partial class FormAltaAlumno : Form
    {
        Alumno nuevoAlumno;

        public Alumno MiNuevoAlumno { get => nuevoAlumno; set => nuevoAlumno = value; }//propertie

        public FormAltaAlumno()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            nuevoAlumno = new Alumno(txt_legajo.Text,txt_nombre.Text,txt_apellido.Text);
            DialogResult = DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
