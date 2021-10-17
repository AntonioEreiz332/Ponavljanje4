using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje4_AE
{
    class Vozilo
    {
        bool jeLiLeti, jeLiPlovi;

        public Vozilo(bool jeLiLeti, bool jeLiPlovi)
        {
            this.jeLiLeti = jeLiLeti;
            this.jeLiPlovi = jeLiPlovi;
        }

        public bool JeLiLeti { get => jeLiLeti; set => jeLiLeti = value; }
        public bool JeLiPlovi { get => jeLiPlovi; set => jeLiPlovi = value; }
        public void KudaVozi()
        {
            Console.WriteLine("Avion leti:" + jeLiLeti + "Brod plovi: " + jeLiPlovi);

        }
        
    }
}
