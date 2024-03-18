using System;
using System.Collections.Generic;
using System.Text;

namespace Briscola_OOP_NEW
{

    class Mazzo  //creo classe mazzo dove inserisco tutte le funzioni che mi servono per gestire il mazzo di carte(inserimento carte, mescola carte, estrai carta e briscola)
    {
        public List<Carte> mazzo = new List<Carte>();//lista dove inserisco tutte le mie carte

        public Mazzo()
        {
            for (int j = 0; j < 4; j++)  //con il primo ciclo aggiungo ogni seme della briscola (bastoni,denari,spade e coppe)
            {
                for (int i = 1; i < 11; i++)  //con il secondo inserisco tutte le carte di quel preciso seme
                {
                    Carte carta = new Carte(i, (seme)j);
                    mazzo.Add(carta);
                }
            }
        }



        public void mescola()
        {
            Random r = new Random();
        
            for (int i = 0; i < 100000; i++)   //tutto ripetuto centomila volte
            {
                int k = r.Next(0, 40);
                int l = r.Next(0, 40);

                Carte aux1 = mazzo[k];
                mazzo[k] = mazzo[l];
                mazzo[l] = aux1; 
            }
        }


        public Carte estrai()
        {
            Carte carta_estratta;

            carta_estratta.valore = 0;
            carta_estratta.Genere = (seme)0;

            if (mazzo.Count >= 1)
            {
                carta_estratta = mazzo[0];
                mazzo.RemoveAt(0);          //rimuovo la carta appena presa
            }

            return carta_estratta;
        }//dopo aver mescolato prendo la prima carta del mazzo partendo da 0 
        public Carte estraibriscola()
        {
            Carte carta_estratta;

            carta_estratta.valore = 0;
            carta_estratta.Genere = (seme)0;
            Random r1 = new Random();

            carta_estratta = mazzo[r1.Next(40)];

            return carta_estratta;

        }//estraggo la briscola a parte per non creare problemi nella giocata finale

    }
}
