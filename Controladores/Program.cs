
using conceptoC.Dtos;
using conceptoC.Servicios;

namespace conceptoC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dtosclase> alumnos = new List<dtosclase>();
            alumnosInterfaz ai = new alumnosImplementacion();
            Console.WriteLine("0.cerrar");
            Console.WriteLine("1.añadir alumnos");
            Console.WriteLine("2.ver lista de alumnos");
            int opcion =Convert.ToInt32(Console.ReadLine());
            bool abrir = false;
            while (!abrir)
            {
                switch (opcion)
                {
                    case 0: Console.WriteLine("cierre de aplicacion"); 
                        abrir = true;
                        break;
                    
                    case 1: 
                        Console.WriteLine("añadir alumno");
                        ai.crearAlumno(alumnos);
                        break;
                    
                    case 2: 
                        Console.WriteLine("ver alumnos");
                        foreach (dtosclase Al in alumnos)
                        {
                          Console.WriteLine(Al.ToString());
                        }     
                        break;
                        
                    default: Console.WriteLine("opcion no valida");
                        break; 
                }
            } 
        }
    }
}