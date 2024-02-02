using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptoC.Dtos
{
    internal class dtosclase
    {
        string nombre = "aaaaaa";
        string apellido = "aaaaaa";
        string fechnacimiento = "aaaaaa";
        string clase = "aaaaaa";
        int edad = 00000;


        public dtosclase(string nombre, string apellido, string clase, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.clase = clase;
            this.edad = edad;

        }
        public dtosclase (){ } 

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Clase { get => clase; set => clase = value; }
        public int Edad { get => edad; set => edad = value; }
         
        override
        public string ToString()
        {
            string alumno = "nombre:  " + this.nombre + " apellidos:  " + this.apellido +
                " clase:  "  + this.clase +" edad:  " +  this.edad ;
            return alumno;
        }
    }
}
