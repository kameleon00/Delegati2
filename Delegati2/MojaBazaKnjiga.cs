﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati2
{
    public class MojaBazaKnjiga
    {

        /*Kreirati klasu BazaKnjga koja u svom konstruktoru inicijalizuje listu knjiga. Ima metode:
           • void dodajKnjigu(Knjiga k), koja dodaje knjigu u listu,
           • void formiranjeUkupneCene(Knjiga k), koja uvećava broj njiga i sabira cenu prosleđene knjige
           • decimal srednjaCena(), racuna srednju cenu knjiga 
          Pored ovih metode definisati i dve metode koje kao parametar imaju DelegatObradeKnjige
           • void knjigeSaTvrdimPovezom(DelegatObradeKnjige processBook)
           • void sveKnjige(DelegatObradeKnjige processBook)

        */
        public int brojKnjiga = 0;
        public decimal cenaKnjiga = 0.0m;

        List<Knjiga> list = new List<Knjiga>();

        public MojaBazaKnjiga()
        {
            dodajKnjigu(new Knjiga("Programski jezik C", "Brian W. Kernighan i Dennis M. Ritchie", 19.95m, true));
            dodajKnjigu(new Knjiga("Prokleta avlija", "Ivo Andrić", 39.95m, true));
            dodajKnjigu(new Knjiga("Derviš i smrt", "Meša Selimović", 129.95m, false));
            dodajKnjigu(new Knjiga("Nauka – Velika ilustrovana enciklopedija ", "Grupa autora", 12.00m, true));
        }
        //===========================================================================================================0000
        //===========================================================================================================0000
        public void dodajKnjigu(Knjiga k)//dodaje knjigu u listu
        {
            list.Add(k);
        }
        //===========================================================================================================0000
        //===========================================================================================================0000
        public void formiranjeUkupneCene(Knjiga k)//uvećava broj njiga i sabira cenu prosleđene knjige
        {
            brojKnjiga += 1;
            cenaKnjiga += k.Cena;
        }
        //===========================================================================================================0000
        //===========================================================================================================0000
        internal decimal srednjaCena()//racuna srednju cenu knjiga
        {
            return cenaKnjiga / brojKnjiga;
        }
        //===========================================================================================================0000
        //===========================================================================================================0000
        //--------- Pored ovih metode definisati i dve metode koje kao parametar imaju DelegatObradeKnjige----------------
        //===========================================================================================================0000
        //===========================================================================================================0000
        public void knjigeSaTvrdimPovezom(DelegatObradjeKnjige processBook)// Poziv delegata za svaku knjigu sa tvrdim povezom da bi je obradio:
        {
            foreach (Knjiga b in list)
            {
                if(b.Tvrdpovez) //tvrdPovez je u klasi Knjiga tip bool
                    processBook(b);// Poziv delegata:
            }
        }
        public void sveKnjige(DelegatObradjeKnjige processBook)// Poziv delegata za svaku knjigu da bi je obradio:
        {
            foreach(Knjiga k in list)
            {
                processBook(k);// Poziv delegata:
            }
        }
        //===========================================================================================================0000
        //===========================================================================================================0000
    }
}
