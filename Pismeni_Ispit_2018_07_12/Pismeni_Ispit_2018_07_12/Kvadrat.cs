﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2018_07_12
{
    public class Kvadrat:Cetverokut //1.3
    {
        public Kvadrat(float a) //konstruktor
        {
            if (a > 0)
            {
                this.a = a;
            }
            else
            {
                throw new ArgumentException("Duljina stranice A ne može biti manja od 0");
            }
            
        }

        //moramo unjeti abstraktne tipve koje smo nasljedili iz cetverokut class
        public override float IzracunajPovrsinu()
        {
            return a * a;
        }

        public override string IspisiPodatke()
        {
            //string ispis = "Kvadrat duljine stranica: " + a +  " povrsine: " + IzracunajPovrsinu();
            //return ispis;
            return String.Format("Kvadrat duljine stranica: " + a + " povrsine: " + IzracunajPovrsinu());
        }

    }
}
