﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class Bank
    {

        public int Kundenummer { get; }

        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public DateTime Dato { get; }

        public string Brugernavn { get; set; }

        public string Password { get; set; }

    }
}
