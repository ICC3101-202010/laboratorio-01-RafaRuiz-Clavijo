using System;

namespace Cachipun
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona jugador = new Persona("Bob","Kunga"); //Constructor -> Indica nombre y apellido
            int play = jugador.Lanzar();                  //Comportamiento
            Console.WriteLine(jugador.getName());         //Verificar que todo funciona
            Console.WriteLine(jugador.getLastName());
            Console.WriteLine("Juego: " + play);

        }
    }
}
