using BibliotecaDeAlumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAlumnos
{
    public partial class FormCrear : Form
    {
        //ATRIBUTO
        private Alumno nuevoAlumno;//crear atributo alumno
        //Atributo nuevoAlumno: atributo de tipo Alumno q se utiliza para almacenar
        //temporalmente el nuevo alumno creado en el formulario.
        
        //CONSTRUCTOR FormCrear()
        public FormCrear()//Este constructor se ejecuta cuando se instancia un objeto de la clase FormCrear.
        {//En este caso, inicializa el formulario llamando al método InitializeComponent().
            InitializeComponent();
        }
        
        //Instanciamos un nuevo estudiante con el boton aceptar
        private void btn_aceptar_Click(object sender, EventArgs e)//Evento btn_aceptar_Click: 
        {//Este método se ejecuta cuando se hace clic en el botón "Aceptar"en el formulario.
            nuevoAlumno = new Alumno(txt_legajo.Text, txt_nombre.Text, txt_apellido.Text);
         //Crea un nuevo objeto Alumno con los datos ingresados
         //en los campos de texto (txt_legajo, txt_nombre y txt_apellido).
            this.DialogResult = DialogResult.OK; //Luego, establece el resultado del formulario en DialogResult.OK,
         //lo que indica que el usuario ha confirmado la acción de crear un nuevo alumno.
        }
        
        private void btn_cancelar_Click(object sender, EventArgs e)//Evento btn_cancelar_Click:
        {//Este método se ejecuta cuando se hace clic en el botón "Cancelar" en el formulario.
            this.DialogResult = DialogResult.Cancel;//Establece el resultado del formulario en DialogResult.Cancel,
           //lo que indica que el usuario ha cancelado la acción de crear un nuevo alumno.
        }
        
        //PROPIEDAD (que retorne estudiante)
        public Alumno MiAlumno //Crear Propiedad GET -metodo q retorne algo del tipo alumno "MiAlumno"
        {//Propiedad MiAlumno: Esta propiedad de solo lectura (get)
        //permite acceder al objeto Alumno creado en el formulario.
            get
            {
                return nuevoAlumno;
            }
        }//Cuando se accede a esta propiedad desde fuera del formulario (por ejemplo, desde el formulario principal),
//devuelve el objeto Alumno que se creó durante la ejecución del formulario.
    }
}



