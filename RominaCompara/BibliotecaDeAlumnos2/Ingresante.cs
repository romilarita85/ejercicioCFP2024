﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeAlumnos2
{
    public class Ingresante
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;
        private string pais;
        private List<string> cursos;//uso lista de tipo string

        public Ingresante(string nombre, string apellido, int edad, string genero, string pais, List<string> cursos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }

        public string Cursos
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < cursos.Count; i++)
                {
                    sb.Append(cursos[i]);

                    if (i < cursos.Count - 1)
                    {
                        sb.Append(" - ");
                    }
                }
                return sb.ToString();
        }
    }
}
