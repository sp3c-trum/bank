using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public interface IOperacjeBankowe
    {
        public abstract void zdeponuj(int kwota);
        public abstract void wyplac(int kwota);
        public abstract int pobierz_saldo();
    }
}
