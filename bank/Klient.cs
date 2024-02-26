using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class Klient
    {
        public KontoOsobiste kontoOsobiste = new KontoOsobiste();
        public KontoOszczednosciowe kontoOszczednosciowe = new KontoOszczednosciowe();
        public KontoFinansowe kontoFinansowe = new KontoFinansowe();
        private string imie;
        private string nazwisko;
        private string telefon;
        private string email;
        private string adres;

        public void wyswietlInfo()
        {
            Console.WriteLine("Imie: " + imie
                + "\nNazwisko: " + nazwisko
                + "\nTelefon: " + telefon
                + "\nEmail: " + email
                + "\nAdres " + adres);
        }

        public void stanKonta()
        {
            int index = 0;
            Console.WriteLine("Wybierz opcję:\n1.Wyświetl stan wszystkich kont." +
                "\n2.Wyświetl stan konta oszczędnościowego" +
                "\n3.Wyświetl stan konta osobistego" +
                "\n4.Wyświetl stan konta finansowego");
            try { index = Int32.Parse(Console.ReadLine()); } catch { Console.WriteLine("Złe dane"); }
            switch (index)
            {
                case 1:
                    int wszystkieKonta = kontoOsobiste.pobierz_saldo() + kontoOszczednosciowe.pobierz_saldo() + kontoFinansowe.pobierz_saldo();
                    Console.WriteLine("\nKonto Osobiste: " + kontoOsobiste.pobierz_saldo()
                        + "\nKonto oszczędnościowe: " + kontoOszczednosciowe.pobierz_saldo()
                        + "\nKonto Finansowe: " + kontoFinansowe.pobierz_saldo()
                        + "\nWszystkie konta: " + wszystkieKonta);
                    break;
                case 3:
                    Console.WriteLine("\nKonto Osobiste: " + kontoOsobiste.pobierz_saldo());
                    break;
                case 2:
                    Console.WriteLine("\nKonto oszczędnościowe: " + kontoOszczednosciowe.pobierz_saldo());
                    break;
                case 4:
                    Console.WriteLine("Konto Finansowe: " + kontoFinansowe.pobierz_saldo());
                    break;
            }
        }
    }
}
