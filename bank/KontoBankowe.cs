using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public abstract class KontoBankowe : IOperacjeBankowe 
    {
        private int stanKonta;

        public void wyplac(int kwota) {
            try
            {
                if (kwota > stanKonta)
                {
                    stanKonta = stanKonta - kwota;
                }
                else
                {
                    Console.WriteLine("Złe dane");
                }
            }
            catch
            {
                Console.Write("Złe dane");
            }
        }

        public void zdeponuj(int kwota) {
            stanKonta = stanKonta + kwota;
        }

        public int pobierz_saldo()
        {
            return stanKonta;
        }
    }
}
