using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Konto
    {
        public  int Kontonummer { get; }

        public  int Kundenummer { get; }

        public  string Fornavn { get; private set; }

        public  string Efternavn { get; private set; }

        public  decimal Saldo { get; private set; } = 0;

        public  DateTime Dato { get; }

    }
}
