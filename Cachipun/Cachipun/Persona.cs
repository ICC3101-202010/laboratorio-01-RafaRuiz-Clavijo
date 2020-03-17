using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cachipun
{
    class Persona
    {
        private string name;
        private string apellido;

        public Persona(string n, string a)
        {
            name = n;
            apellido = a;
        }
        public int Lanzar()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 3);
            return a;
        }

        //Estas funciones estan para verificar que todo funciona
        public string getName()
        {
            return this.name;
        }

        public string getLastName()
        {
            return this.apellido;
        }
    }
}
