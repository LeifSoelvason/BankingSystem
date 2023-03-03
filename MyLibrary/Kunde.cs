using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Kunde
    {
        public int Kundenummer { get; }

        public int Kontonummer { get; set; }

        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public DateTime Dato { get; }

        public string Brugernavn { get; set; }

        public string Password { get; set; }
    }
}
