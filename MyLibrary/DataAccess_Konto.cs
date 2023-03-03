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
    public class DataAccess_Konto
    {

        public void NyKonto(string Fornavn, string Efternavn, int Kundenummer)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                connection.Execute("dbo.sp_NyKonto @Fornavn, @Efternavn, @Kundenummer", new { Fornavn, Efternavn, Kundenummer });
            }
        }

        public List<Konto> MineKonti(int Kundenummer)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                var output = connection.Query<Konto>("sp_MineKonti @Kundenummer", new { Kundenummer = Kundenummer }).ToList();
                return output;
            }
        }

        public void IndsætPenge(int kontonummer, decimal beløb)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Kontonummer", kontonummer);
                parameters.Add("@Beløb", beløb);
                connection.Execute("dbo.sp_IndsætPenge", parameters, commandType: CommandType.StoredProcedure);
            }

        }

        public void HævPenge(int kontonummer, decimal beløb)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Kontonummer", kontonummer);
                parameters.Add("@Beløb", beløb);
                connection.Execute("dbo.sp_HævPenge", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public decimal VisSaldo(int kontonummer)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("Bank_DB")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Kontonummer", kontonummer);
                var output = connection.Query<decimal>("dbo.sp_VisSaldo", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return output;
            }
        }
    }
}
