using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pismeni_Ispit_2018_07_12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2018_07_12.Tests
{
    [TestClass()]
    public class PovrsinaTests
    {
        //Pravokutnik
        [TestMethod()]
        public void PovrsinuPravokutnika()
        {
            Cetverokut c = new Pravokutnik(5, 10);
            Assert.AreEqual(50, c.IzracunajPovrsinu());
        }

        //Kvadrat
        [TestMethod()]
        public void PovrsinuKvadrat()
        {
            Cetverokut c = new Kvadrat(5);
            Assert.AreEqual(25, c.IzracunajPovrsinu());
        }

        //Ukupna povrsina spremnika
        [TestMethod()]
        public void UkupnaPovrsinaSpremnik()
        {
            Cetverokut c1 = new Kvadrat(5);
            Cetverokut c2 = new Pravokutnik(5, 10);

            Spremnik s = new Spremnik();

            s.DodajCetverokut(c1);
            s.DodajCetverokut(c2);

            Assert.AreEqual(75, s.PovrsinaSvihCetverokuta());
        }

    }


}