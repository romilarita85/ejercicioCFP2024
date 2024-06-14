using BibliotecaDeLapiceras;
namespace Form_Lapicera
{
    public partial class FormPrincipal : Form
    {
        List<Lapicera> lapiceras;//lista para guardar lapiceras
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lapiceras = new List<Lapicera>();//instanciar lista lapiceras
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();//crea nueva instancia del formAlta
            formAlta.ShowDialog();//ivocar nueva instancia
            
            if (formAlta.DialogResult == DialogResult.OK)//Evaluar q respuesta de la propertie formAlta
            {//si la respuesta fue ok agrego nueva lapicera a mi lista de lapiceras
                lapiceras.Add(formAlta.Lapicera);//uso protertie Lapicera creada en formAlta 
                dgv_listaDeLapiceras.DataSource = null;//nulearla por default-evita repeticiones
                dgv_listaDeLapiceras.DataSource = lapiceras;//Cargar mi Data grew con la lista q acabo de ir incrementando
            }


        }
    }
}
