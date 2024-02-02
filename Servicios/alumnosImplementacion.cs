using conceptoC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptoC.Servicios
{
    internal class alumnosImplementacion : alumnosInterfaz
    {
        public void crearAlumno(List<dtosclase> alum)
        {
            dtosclase crenuevoAl = new dtosclase();
            Console.WriteLine("Escribe el nombre");
            crenuevoAl.Nombre = Console.ReadLine();
            Console.WriteLine("Escribe el apellido");
            crenuevoAl.Apellido = Console.ReadLine();
            Console.WriteLine("Escribe la clase");
            crenuevoAl.Clase = Console.ReadLine();
            alum.Add(crenuevoAl);
        }
    }

}
