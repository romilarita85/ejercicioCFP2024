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

namespace FormRegistrate
{
    public partial class FormAlta : Form
    {//crear atributo ingresante 
        Ingresante ingresante;//lograr que cuando haga clik en formAlta diseño me cree una instancia de ese ingresante
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int)num_edad.Value;
            string genero;
            string pais = lst_paises.Text;; //o lst_paises.SelectedItem.ToString()
            List<string> cursos;
        }
    }
}
