using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2018_07_12
{
    class Spremnik //2.0
    {
        public List<Object> list = new List<object>();

        public void DodajCetverokut(Cetverokut c)
        {
            list.Add(c);
        }

        public float PovrsinaSvihCetverokuta()
        {
            float povrsina=0f;
            foreach (Cetverokut c in list)
            {
                povrsina += c.IzracunajPovrsinu();
            }
            return povrsina;
        }
    }
}
