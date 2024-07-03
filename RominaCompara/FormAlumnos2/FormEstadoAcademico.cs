using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeAlumnos;
namespace FormAlumnos2
{
    public partial class FormEstadoAcademico : Form
    {
        Alumno alumno;
        string carrera;
        List<Materia> materias;
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public List<Materia> Materias { get => materias; set => materias = value; }
        
        public FormEstadoAcademico()
        {
            InitializeComponent();
        }

        public FormEstadoAcademico(Alumno alumno, string carrera, List<Materia> materias):this()
        {
            this.alumno = alumno;
            this.carrera = carrera;
            this.materias = materias;
        }

        private void FormEstadoAcademico_Load(object sender, EventArgs e)
        {
            this.CargarListEstAcad();
        }
       
        private void CargarListEstAcad()
        {
            lst_estadoAcademico.Items.Add(alumno);
            lst_estadoAcademico.Items.Add($"Carrera: {carrera}");
            lst_estadoAcademico.Items.Add("Listado de materias: ");
            
            foreach (Materia item in materias)
            {
                lst_estadoAcademico.Items.Add(item.Nombre);
            }
        }
    }
}
