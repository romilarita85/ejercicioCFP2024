using PrimerEvaluacionAuto;
namespace Formulario_Auto
{
    public partial class FormAuto : Form
    {
        List<Auto> misAutos;
        //int cantidadDeAutos;
        public FormAuto()
        {
            InitializeComponent();

        }
        private void FormAuto_Load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.cmb_colores.Items.AddRange(Auto.ColoresValidos().ToArray());
        }

        private void btn_crear_Click(object sender, EventArgs e) //Evento
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            string color = this.cmb_colores.Text;

            DialogResult respuesta; // crear variable del tipo resultado

            Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto

            respuesta = MessageBox.Show("Decea agregar este AUTO","Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//se muestra el mensaje
            //parametros del MessageBox ->( ****mensaje*****+****,Titulo***, Que Botones va a tener , icono*************)

            //if (respuesta == DialogResult.Yes)
            //{
            //    misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos (lo agrega o no)
            //}
            //else
            //{
            //    MessageBox.Show("Auto no agregado");
            //} 

            this.Limpiar();
        }
        private void Limpiar()
        {//función privada para borrar o "limpiar" los campos de entrada del formulario(interfaz gráfica de usuario).
            this.txt_marca.Text = string.Empty;
            this.txt_combustible.Text = string.Empty;
            this.cmb_colores.Text = string.Empty;
        }

        private void btn_mostrar_Click(object sender, EventArgs e) //Evento
        {
            this.VaciarLst();
            this.lst_misAutos.Items.AddRange(misAutos.ToArray());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)//Evento
        {
            this.VaciarLst();
        }
        private void VaciarLst() //metodo (no asociado a un evento)
        {
            this.lst_misAutos.Items.Clear();

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

//    Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto

//    respuesta = MessageBox.Show($"Decea agregar el auto {miAuto.GetMarca()}?", "Agregar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);//se muestra el mensaje                                                                                                                       //parametros del MessageBox -> mensaje *********+****,Titulo***, Que Botones va a tener , icono*************

//    switch (respuesta) //Para evaluar que boton esta apretando
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