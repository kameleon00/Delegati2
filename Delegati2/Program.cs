﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati2
{
    //===========================================================================================================0000
    //===========================================================================================================0000
    /*U glavnom programu kreirati metodu
    • void stampanjeNaslova(Knjiga k) */

    // Deklaracija delegata za obradu knjige:
    public delegate void DelegatObradjeKnjige(Knjiga book);
        // Sadrzi bazu k.
      
        // Klasa za testiranje knjige u bazi:
        class Program
        {
            // Štampanje naslova objekta k (knjige).
            static void stampanjeNaslova(Knjiga k)
            {
                Console.WriteLine(" {0}", k.Naslov);
            }

        //===========================================================================================================0000
        //===========================================================================================================0000
        // Izvršavanje počinje ovde.
        static void Main()
            {
            MojaBazaKnjiga baza = new MojaBazaKnjiga();

                // Štampanje svih naslova :
                Console.WriteLine("Ispis knjiga:");
                // Kreiranje novog objekta delegata koji se odnosi na
                // staticki metod StampanjeNaslova klase Program
                // REZULTAT - STAMPANJE NASLOVA SVIH KNJIGA
                baza.sveKnjige(new DelegatObradjeKnjige(stampanjeNaslova));
                // Štampanje svih naslova sa tvrdim povezom:
                Console.WriteLine("Knjige sa tvrdim povezom su:");
            // Kreiranje novog objekta delegatta koji se odnosi na
            // staticki metod StampanjeNaslova klase Program
            // REZULTAT - STAMPANJE NASLOVA KNJIGA SA TVRDIM POVEZOM
                baza.knjigeSaTvrdimPovezom(new DelegatObradjeKnjige(stampanjeNaslova));
                // Kreiranje novog objekta delegata object koji se odnosi na
                // nestatički metod FormiranjeUkupneCene na objektu baza:
                // REZULTAT - FORMIRANJE SREDNJE CENE SVIH KNJIGA
                baza.sveKnjige(new DelegatObradjeKnjige(baza.formiranjeUkupneCene));
                Console.WriteLine("Srednja cena svih knjiga je: ${0:#.##}", baza.srednjaCena());
                // Kreiranje novog objekta delegata object koji se odnosi na
                // nestatički metod FormiranjeUkupneCene na objektu baza:
                // REZULTAT - FORMIRANJE SREDNJE CENE KNJIGA SA TVRDIM POVEZOM
                baza.knjigeSaTvrdimPovezom(new DelegatObradjeKnjige(baza.formiranjeUkupneCene));
                Console.WriteLine("Srednja cena knjiga sa tvrdim povezom je: ${0:#.##}", baza.srednjaCena());
                Console.ReadKey();
            }
        }
    
}
