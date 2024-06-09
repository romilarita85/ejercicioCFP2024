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
        private Materia miMateria;//atributo privado miMateria de tipo Materia,que representa
                                  //la materia que se va a agregar.
        public FormAltaMateria() //CONSTRUCTOR
        {//El constructor del formulario inicializa los componentes del formulario.
            InitializeComponent();
        }
        //El método btn_aceptar_Click maneja el evento de hacer clic en el botón "Aceptar".
        //Verifica si se ha ingresado un nombre de materia válido y, si es así,
        //crea una nueva instancia de la clase Materia con el nombre proporcionado y establece
        //el resultado del formulario como DialogResult.OK.
        //Si el nombre de la materia está vacío,muestra un mensaje de advertencia.
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

        //El método btn_cancelar_Click maneja el evento de hacer clic en el botón "Cancelar"
        //y establece el resultado del formulario como DialogResult.Cancel.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //PROPERTIE: para saber a quien llamo
        public Materia MiMateria
        {//Hay una propiedad pública MiMateria que devuelve la materia creada cuando se hace clic en el botón "Aceptar".
            get
            {
                return this.miMateria;//se retorna el atributo miMateria
            }
        }
    }
}

//En resumen, este formulario permite al usuario agregar una nueva materia ingresando un nombre
//y luego aceptando o cancelando la operación. Si la materia se agrega exitosamente,
//el formulario principal puede obtener la materia creada a través de la propiedad MiMateria.

//El método IsNullOrEmpty es un método estático proporcionado por la clase String en C#.
//Este método se utiliza para verificar si una cadena de texto (string) es nula o está vacía.