using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matematicas", "Mat1241212");
            Grupo historia = new Grupo("Historia", "Hist684644");
            //tambien para no repetir variables

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "123125123");
            Alumno maria = new Alumno("Maria", "132412");
            Alumno pedro = new Alumno("Pedro", "16874354");
            Alumno ana = new Alumno("Ana", "12312313");
            Alumno pablo = new Alumno("Pablo", "464546");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(maria);
            historia.Alumnos.Add(pedro);

            matematicas.Alumnos.Add(ana);
            matematicas.Alumnos.Add(pablo);
            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(maria);
            matematicas.Alumnos.Add(pedro);

            foreach(Grupo grupo in grupos)
            {

                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia: " + grupo.Materia);
                Console.WriteLine("Lista de Alumnos: ");
                foreach (Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }


            }
            Console.Read();
        }
    }
}
