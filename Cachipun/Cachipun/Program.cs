using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachipun
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona jugador = new Persona("Bob", "Kunga"); //Constructor -> Indica nombre y apellido               
            Console.WriteLine(jugador.getName());         //Verificar que todo funciona
            Console.WriteLine(jugador.getLastName());
            Console.WriteLine("Juego: " + jugador.Lanzar()); //Comportamiento
        }
    }
}
