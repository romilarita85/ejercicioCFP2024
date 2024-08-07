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
    public partial class ForEstadoAcademico : Form
    {
        Alumno alumno;
        List<Materia> materias;
        string carrera;
        public ForEstadoAcademico() //Constructor vacio
        {
            InitializeComponent();
        }
       
        public ForEstadoAcademico(Alumno alumno, List<Materia> materias, string carrera) : this() //SOBRECARGA CONST
        {//Constructor con parametros
            this.alumno = alumno;
            this.materias = materias;
            this.carrera = carrera;
        }
        private void ForEstadoAcademico_Load(object sender, EventArgs e)
        {
            CargarLsb();
        }
        private void CargarLsb()
        {
            lst_estadoAcademico.Items.Add(alumno);
            lst_estadoAcademico.Items.Add($"Carrera: {carrera}");
            lst_estadoAcademico.Items.Add("Listado de materias:");

            foreach (Materia item in materias)
            {
                lst_estadoAcademico.Items.Add(item.Nombre); //IR AGREGANDO MATERIA DENTRO DE LA COLECCION DE MATERIAS
                
            }
        }

 
    }
}
