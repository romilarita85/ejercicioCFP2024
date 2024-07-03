using BibliotecaDeAlumnos2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegistrate_2
{
    public partial class FormAlta : Form
    {
        private Ingresante nuevoIngresante;
        public Ingresante NuevoIngresante { get => nuevoIngresante; set => nuevoIngresante = value; }
        public FormAlta()
        {
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            lst_paises.DataSource = new List<string>()
            {
                "Argentina","Colombia","Venezuela","Chile","Ecuador","Peru"
            };
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_nombre.Text;
            int edad = (int)num_edad.Value;
            string pais = lst_paises.Text;

            string genero = string.Empty;//gpv_generos
            List<string> cursos = new List<string>();//gpv_cursos

            foreach (RadioButton rd in gpb_generos.Controls)
            {
                if (rd.Checked == true)
                {
                    genero = rd.Text;
                    break;
                }
            }
            foreach (CheckBox chk in gpb_cursos.Controls)
            {
                if (chk.Checked == true)
                {
                    cursos.Add(chk.Text);
                    break;
                }

            }
            nuevoIngresante = new Ingresante(nombre, apellido, edad, genero, pais, cursos);
            DialogResult = DialogResult.OK;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
