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
    public class DataAccess_Bank
    {

        public void OpretKunde(string Fornavn, string Efternavn, string Brugernavn, string Password)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                connection.Query<Bank>("dbo.sp_OpretKunde @Fornavn, @Efternavn, @Brugernavn, @Password", new { Fornavn = Fornavn, Efternavn = Efternavn, Brugernavn = Brugernavn, Password = Password });
            }
        }


        public void TilføjKundeTilBank(int kundenummer)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                connection.Query<Bank>("dbo.sp_TilføjKundeTilBank @Kundenummer", new { Kundenummer = kundenummer });
            }
        }

        


    }
}
