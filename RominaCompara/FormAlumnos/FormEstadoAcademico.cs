﻿using BibliotecaDeAlumnos;
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
        public ForEstadoAcademico()
        {
            InitializeComponent();
        }

        public ForEstadoAcademico(Alumno alumno, List<Materia> materias, string carrera):this()
        {
            this.alumno = alumno;
            this.materias = materias;
            this.carrera = carrera;
        }

        private void CargarLsb(object sender, EventArgs e)
        {
            lst_estadoAcademico.Items.Add(alumno);
            lst_estadoAcademico.Items.Add($"carrera:{carrera}");
            lst_estadoAcademico.Items.Add("Listado de materias:");

            foreach (Materia item in materias)
            {
                lst_estadoAcademico.Items.Add(item.Nombre);
            }
        }

    }
}
