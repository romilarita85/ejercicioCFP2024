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

        public Ingresante Ingresante { get => ingresante; }//Creo PROPERTIE q me permita exponer el valor de ingresante

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            
            lst_paises.DataSource = new List<string>()
            {
                "Argentina","Colombia","Uruguay","Ecuador","Chile","Venezuela","Cuba"
            } ;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int)num_edad.Value;//Casteo de forma explicita
            string genero = string.Empty;//Por default string vacio-Se debe inicializar todos los atributos
            string pais = lst_paises.Text; ; //o lst_paises.SelectedItem.ToString()
            List<string> cursos = new List<string>(); //instanciar la lista de cursos


            foreach (RadioButton rd in gpb_generos.Controls)//Sacar algo del tipo radioButton en cada vuelta
            {
             //Saco algo del tipo radioButton en la coleccion del groupbox_genero por medio del operador punto accedo a propiedad Controls
                if (rd.Checked == true)//para verificar el componente (rd)q acabamps de sacar-> ver en q estado esta
                {//si es true ->fue chequeado
                    genero = rd.Text;
                    break;
                }
            }
            foreach (CheckBox ck in gpb_cursos.Controls)//sacamos checkbox del grupo donde esta contenido y acceder a la propiedad Controls
            {
                if (ck.Checked == true)
                {
                    cursos.Add(ck.Text);
                }
            }
            ingresante = new Ingresante(nombre, apellido, edad, genero, pais, cursos);//creo una nueva instancia
            //que el atributo creado sea igual al la nueva instancia del tipo Ingresante
            //tengo q pasarle nombre,apellido,edad,genero,pais y la lista de cursos
            DialogResult = DialogResult.OK;//dar resultado ok a la propiedad DialogResult
        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

//*******************Metodos
//private string ObtenerGeneroSeleccionado(GroupBox gpv_generos)
//{//Saco algo del tipo radioButton en la coleccion del groupbox_genero
// //por medio del operador punto accedo a propiedad Controls
//    string genero = string.Empty;
//    foreach (RadioButton rd in gpv_generos.Controls)
//    {
//        if (rd.Checked)
//        {
//            genero = rd.Text;
//            break;
//        }
//    }
//    return genero;
//}
//private string ObtenerCursosSeleccionado(CheckBox gpv_cursos)
//{
//    foreach (CheckBox ck in gpv_cursos.Controls)
//    {
//        if (ck.Checked)
//        {
//            cursos.Add(ck.Text); 
//            break;
//        }
//    }
//    return cursos;
//}

//****************************************

//*******************************************************+
//using BibliotecaDeAlumnos;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace FormRegistrate
//{
//    public partial class FormAlta : Form
//    {//crear atributo ingresante 
//        Ingresante ingresante;//lograr que cuando haga clik en formAlta diseño me cree una instancia de ese ingresante

//        public Ingresante Ingresante { get => ingresante; }//Creo propertie q me permita exponer el valor de ingresante

//        public FormAlta()
//        {
//            InitializeComponent();
//        }

//        private void FormAlta_Load(object sender, EventArgs e)
//        {

//            lst_paises.DataSource = new List<string>()
//            {
//                "Argentina","Colombia","Uruguay","Ecuador","Chile","Venezuela","Cuba"
//            };
//        }

//        private void btn_agregar_Click(object sender, EventArgs e)
//        {
//            string nombre = txt_nombre.Text;
//            string apellido = txt_apellido.Text;
//            int edad = (int)num_edad.Value;//Casteo de forma explicita
//            string genero = string.Empty;//Por default string vacio-Se debe inicializar todos los atributos
//            string pais = lst_paises.Text; ; //o lst_paises.SelectedItem.ToString()
//            List<string> cursos = new List<string>(); //instanciar la lista de cursos

//            foreach (RadioButton rd in gpb_generos.Controls)//Sacar algo del tipo radioButton en cada vuelta
//            {//esa coleccion esta en mi gpv_generos y debo acceder a su atributo donde esten guardados todos los componentes por
//             //medio de la propiedad Controls
//             //Saco algo del tipo radioButton en la coleccion del groupbox_genero por medio del operador punto accedo a propiedad Controls
//                if (rd.Checked == true)//para verificar el componente (rd)q acabamps de sacar-> ver en q estado esta
//                {//si es true ->fue chequeado
//                    genero = rd.Text;
//                    break;
//                }
//            }
//            foreach (CheckBox ck in gpb_cursos.Controls)//sacamos checkbox del grupo donde esta contenido y acceder a la propiedad Controls
//            {
//                if (ck.Checked)
//                {
//                    cursos.Add(ck.Text);
//                }
//            }
//            ingresante = new Ingresante(nombre, apellido, edad, genero, pais, cursos);//creo una nueva instancia
//            //que el atributo creado sea igual al la nueva instancia del tipo Ingresante
//            //tengo q pasarle nombre,apellido,edad,genero,pais y la lista de cursos
//            DialogResult = DialogResult.OK;//dar resultado ok a la propiedad DialogResult
//        }


//        private void btn_cancelar_Click(object sender, EventArgs e)
//        {
//            DialogResult = DialogResult.Cancel;
//        }
//    }
//}
