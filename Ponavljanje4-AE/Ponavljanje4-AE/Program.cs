using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje4_AE
{
    class Program
    {
        static void Main(string[] args)
        {
            Brod Brod = new Brod();
            Zrakoplov Avion = new Zrakoplov();
            Console.WriteLine("Brod leti: " + Brod.JeLiLeti +"\n"+"Brod plovi: "+Brod.JeLiPlovi+"\n" );
            Console.WriteLine("Avion leti: " + Avion.JeLiLeti + "\n" + "Avion plovi: " + Avion.JeLiPlovi + "\n");
            Console.ReadKey();
        }
    }
}
