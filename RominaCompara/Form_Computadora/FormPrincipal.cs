using BibliotecaDeComputadoras;
namespace Form_Computadora
{
    public partial class FormPrincipal : Form
    {
        List<Computadora> computadoras;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.computadoras = new List<Computadora>();
            this.computadoras = new List<Computadora>() //dar una nueva instancia a la lista (inicializar lista)
            {
                new Computadora(240,16,"Pentium","Linux"),
                new Computadora(480,32,"Celeron","Android"),
                new Computadora(240,16,"Core 2","Unix"),
                new Computadora(480,32,"Intel Pentium","Window Server"),
                new Computadora(240,16,"Intel 386","Chrome Os"),
            };
            CargarDgv();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Crear una nueva instancia de la lista
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();//hacer que sea visible

            if (formAlta.DialogResult == DialogResult.OK)
            {
                this.computadoras.Add(formAlta.MiComputadora);

            }
            CargarDgv();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Dos formas de sacar un elemento de dataGrew
            //1-Por medio de la palabra reservada "as"
            Computadora pcEditar = (Computadora)dgv_listaComputadoras.CurrentRow.DataBoundItem as Computadora;
            //2-otra forma
            //Computadora pcEditar = (Computadora)dgv_listaComputadoras.CurrentRow.DataBoundItem;

            FormModificar modificar = new FormModificar(pcEditar);//paso pcEditar al constructor
            modificar.ShowDialog();

            if (modificar.DialogResult == DialogResult.OK)
            {
                //Buscar numero de serie-Buscar como obtiene ese indice(dato numerico)
                int index = -1;//si es distinto de -1 significa q lo puedo encontrar.
                foreach (Computadora item in computadoras)
                {
                    if (item.NumeroDeSerie == modificar.MiComputadora.NumeroDeSerie)
                    {
                        index = computadoras.IndexOf(item);
                    }
                    if (index != -1) //para decirla a mi computadora q guarde ese indice de la computadora
                    {//q yo modifique
                        computadoras[index] = modificar.MiComputadora;
                    }
                }
                CargarDgv();

            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Computadora pcEliminar = (Computadora)dgv_listaComputadoras.CurrentRow.DataBoundItem as Computadora;
            DialogResult rta = MessageBox.Show($"Esta seguro que desea eliminar la pc con numero de serie {pcEliminar.NumeroDeSerie}" +
                $"Esta accion es irreversible", 
                "ELIMINAT",MessageBoxButtons.OKCancel);

          
            if (rta == DialogResult.OK)
            {
                computadoras.Remove(pcEliminar);    
            }
            CargarDgv();
        }
        private void CargarDgv()
        {
            dgv_listaComputadoras.DataSource = null;
            dgv_listaComputadoras.DataSource = computadoras;
        }

        
    }

}
//private void btn_modificar_Click(object sender, EventArgs e)
//{
//    //Dos formas de sacar un elemento de dataGrew
//    //1-Por medio de la palabra reservada "as"
//    Computadora pcEditar = (Computadora)dgv_listaComputadoras.CurrentRow.DataBoundItem as Computadora;
//    //2-otra forma
//    //Computadora pcEditar = (Computadora)dgv_listaComputadoras.CurrentRow.DataBoundItem;

//    FormModificar modificar = new FormModificar(pcEditar);//paso pcEditar al constructor
//    modificar.ShowDialog();

//    if (modificar.DialogResult == DialogResult.OK)
//    {
//        // Encuentra el índice del objeto en la lista
//        int index = this.computadoras.FindIndex(pcBuscar => pcBuscar.NumeroDeSerie == modificar.MiComputadora.NumeroDeSerie);
//        // Reemplaza el objeto en la lista con el objeto modificado
//        this.computadoras[index] = modificar.MiComputadora;
//        // Actualiza el DataGridView con la lista actualizada
//        CargarDgv();

//    }
//}
//CurrentRow:en DataGrid wiew te permite acceder a la fila actualmente seleccionada o con foco.
//Te permite interactuar con los datos de esa fila, realizar operaciones específicas o
//mostrar información relevante.

//DataBoundItem: devolver como si fuera un objeto. Para el dataGrew todo lo que va a devolver va a ser
//del tipo objetc-> objeto q le pasamos inicialmente. Devuelve el objeto que está vinculado a la fila actual.
//Este objeto es de la misma clase que la que se usó para llenar el DataGridView.

//Casteo a Computadora: La conversión(casting) (Computadora)asume que el objeto vinculado
//a la fila es de tipo Computadora. Este casting te permite trabajar directamente
//con el objeto Computadora en lugar de tratar con el objeto base genérico. 

//index: El índice te dice en qué posición de la colección se encuentra un elemento específico.
//FindIndex:método de List<T> en C# que busca el índice del primer elemento que cumple con una
//condición especificada mediante un delegado Predicate<T>. Es útil cuando no conoces
//la posición del elemento pero sí una condición para identificarlo.