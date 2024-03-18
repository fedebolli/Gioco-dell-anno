using System;
using System.Collections.Generic;
using System.Text;

namespace Briscola_OOP_NEW
{
    public class Carte
    {
        public int valore;
        public seme Genere;
        

        public Carte(int valore,seme Genere)
        {
            this.valore = valore;
            this.Genere = Genere;
        }
    }
}
