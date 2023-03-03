using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MyLibrary
{
    public class DataAccess_Kunde
    {
        

        public List<DataAccess_Kunde> PasswordValidation(string Brugernavn, string Password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                var output = connection.Query<DataAccess_Kunde>("dbo.sp_ValidateBruger @Brugernavn,@Password", new { Brugernavn = Brugernavn, Password = Password }).ToList();
                return output;
            }
        }

        

    }
}

