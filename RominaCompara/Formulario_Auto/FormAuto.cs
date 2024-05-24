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

        private void btn_crear_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            string color = this.cmb_colores.Text;

            Auto miAuto = new Auto(marca, combustible, color); //crear objeto del tipo auto

            misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos.

            

            this.Limpiar();
        }
        private void Limpiar()
        {//funci�n privada para borrar o "limpiar" los campos de entrada del formulario(interfaz gr�fica de usuario).
            this.txt_marca.Text = string.Empty;
            this.txt_combustible.Text = string.Empty;
            this.cmb_colores.Text = string.Empty;
        }

        private void btn_mostrar_Click(object sender, EventArgs e) //Evento
        {
            //captura 1237
            this.lst_misAutos.Items.AddRange(misAutos.ToArray());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)//Evento
        {
            this.lst_misAutos.Items.Clear();
        }
        private void VaciarLst() //metodo (no asociado a un evento)
        {
            this.lst_misAutos.Items.Clear();

        }

    }
}
//misAutos.Add(miAuto); //agrega el objeto miAuto a la lista llamada misAutos.

//this.lst_misAutos.Items.AddRange(misAutos.ToArray()); //->agrega m�ltiples elementos de una colecci�n a la lista.

//this.lst_misAutos.Items.Add(miAuto.AutoToString());//->agrega una representaci�n en forma de cadena de un objeto a la lista.
//agrega una representaci�n en forma de cadena del objeto miAuto a la lista lst_misAutos.
//AutoToString() es un m�todo que devuelve una cadena que representa el objeto miAuto,
//esta l�nea agrega esa cadena a la lista.

//this.lst_misAutos.Items.Add(miAuto);//->agrega el objeto en s� a la lista.
//el objeto miAuto se agregar� a la lista tal como est�.
