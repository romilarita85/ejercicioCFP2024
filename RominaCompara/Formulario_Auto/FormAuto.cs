using LibreriaDeFunciones;
using PrimerEvaluacionAuto;
namespace Formulario_Auto
{
    public partial class FormAuto : Form
    {
        List<Auto> misAutos;
        //int cantidadDeAutos;
        public FormAuto()//CONSTRUCTOR FormAuto, inicializa la lista de autos misAutos y configura los eventos del formulario.            
        {
            InitializeComponent();
        }
        private void FormAuto_Load(object sender, EventArgs e)
        {//inicializas misAutos y cargas los colores válidos en el ComboBox cmb_colores.
            this.misAutos = new List<Auto>();
            //this.cmb_colores.Items.AddRange(Auto.ColoresValidos().ToArray());
            
            this.CargarCMB(Auto.ColoresValidos());
            //this.cmb_colores.DataSource = Auto.ColoresValidos();

        }
        private void btn_crear_Click(object sender, EventArgs e) //EVENTO
        {//-creas un nuevo objeto Auto con la información ingresada por el usuario,
         //-preguntas al usuario si desea agregar el auto a la lista de autos.
         //-Si la respuesta es afirmativa, agrega el auto a la lista misAutos.
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            Color color = (Color)this.cmb_colores.SelectedItem;

            DialogResult respuesta; // crear variable del tipo resultado
           
            if (this.ValidarEntradas(marca,combustible)) 
            {
                Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto
                respuesta = MessageBox.Show($"Decea agregar el auto {miAuto.GetMarca()}","Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//se muestra el mensaje
               //parametros del MessageBox ->( ******************MENSAJE***********+****,**TITULO**, Que BOTONES va a tener ,********ICONO**********)

                if (respuesta == DialogResult.No)
                {
                    MessageBox.Show("Auto no agregado");
                }
                else
                {
                    misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos (lo agrega o no)
                }
                this.Limpiar();
            } 
        }
        private void Limpiar() //FUNCION
        {//función privada para borrar o "limpiar" los campos de entrada del formulario(interfaz gráfica de usuario).
            this.txt_marca.Text = string.Empty;
            this.txt_combustible.Text = string.Empty;
            this.cmb_colores.Text = string.Empty;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)//EVENTO
        {//muestras los autos en el ListBox lst_misAutos.
            this.VaciarLst();

            this.lst_misAutos.Items.AddRange(misAutos.ToArray());
            //this.lst_misAutos.DataSource = misAutos; //Funciona igual que el addRange
        }

        private void btn_limpiar_Click(object sender, EventArgs e)//EVENTO
        { //vacías el ListBox lst_misAutos.
            this.VaciarLst();
        }
        private void VaciarLst() //METODO (no asociado a un evento)
        {
            this.lst_misAutos.Items.Clear();

        }
        private bool ValidarEntradas(string marca, string combustible) //Metodo-> Creo un constructor 3°
        {//validas la entrada del usuario para la marca y el combustible del auto.
            bool ok = true;
            if (!MisFunciones.EsSoloLetras(marca))
            {
                MessageBox.Show("La marca debe ser solo letras");
                ok = false;
            }
            if (!MisFunciones.EsNumerico(combustible))
            {
                MessageBox.Show("El combustible debe ser numerico");
                ok = false;
            }
            return ok;

        }
        private void CargarCMB(List<Color>colores)//METODO->Cargas los colores en el ComboBox cmb_colores.
        {//El método CargarCMB es parte de una clase que tiene un control ComboBox (cmb_colores)
         //y se utiliza para cargar una lista de colores en ese ComboBox.
         //foreach (Color color in colores)
         //{
         //    this.cmb_colores.Items.Add(color);  
         //}
            this.cmb_colores.DataSource = colores;
        }
    }
}
//misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos.

//this.lst_misAutos.Items.AddRange(misAutos.ToArray()); //->agrega múltiples elementos de una colección a la lista.

//this.lst_misAutos.Items.Add(miAuto.AutoToString());//->agrega una representación en forma de cadena de un objeto a la lista.
//agrega una representación en forma de cadena del objeto miAuto a la lista lst_misAutos.

//AutoToString() es un método que devuelve una cadena que representa el objeto miAuto,
//esta línea agrega esa cadena a la lista.

//this.lst_misAutos.Items.Add(miAuto);//->agrega el objeto en sí a la lista.
//el objeto miAuto se agregará a la lista tal como está.



//private void btn_crear_Click(object sender, EventArgs e) //Evento
//{
//    string marca = this.txt_marca.Text;
//    string combustible = this.txt_combustible.Text;
//    string color = this.cmb_colores.Text;

//    DialogResult respuesta; // crear variable del tipo resultado

// double combValido;
//if (!double.TryParse(combustible, out combValido))
//{// Estás utilizando double.TryParse para intentar convertir la cadena
// combustible en un valor numérico tipo double.
// Si la conversión falla, es decir, si combustible no puede ser convertido
// a un valor numérico double, se muestra un mensaje indicando que el combustible debe ser numérico.
//    MessageBox.Show("El combustible debe ser numerico");
//}

//    Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto

//    respuesta = MessageBox.Show($"Decea agregar el auto {miAuto.GetMarca()}?", "Agregar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);//se muestra el mensaje                                                                                                                       //parametros del MessageBox -> mensaje *********+****,Titulo***, Que Botones va a tener , icono*************

//    switch (respuesta) //Para evaluar que boton esta apretando-Multiples respuestas-si uso dos resp-> condicional.
//    {
//        case DialogResult.Yes:
//            MessageBox.Show("Apreto el boton YES");
//            break;
//        case DialogResult.No:
//            MessageBox.Show("Apreto el boton NO");
//            break;
//        case DialogResult.Cancel:
//            MessageBox.Show("Apreto el boton CANCEL");
//            break;
//    }
//    this.Limpiar();
//}

//if (respuesta == DialogResult.Yes)
//{
//    misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos (lo agrega o no)
//}
//else
//{
//    MessageBox.Show("Auto no agregado");
//} 


