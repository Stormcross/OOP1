using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektHelix3D.GeometrijskaTjela;

namespace ProjektHelix3D.Enumeracije
{
    class KreatorOblika
    {
        public static GeometrijskoTijelo Vrati(Operacije operacija)
        {
            switch (operacija)
            {
                case Operacije.CrtajKvadar:
                    return new Kvadar();
                case Operacije.CrtajKvadrat:
                    return null;
                case Operacije.CrtajKuglu:
                    return null;
                default:
                    throw new ArgumentException("Nepostojeci oblik");
            }
        }
    }
}
