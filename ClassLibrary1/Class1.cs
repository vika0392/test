using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;  
namespace ClassLibrary1
{
    public class Class1
    {
        public String Test()
        {
            string oradb = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.164)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=IPSTest))); User Id=time_tracker;Password=time1234;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            string sql = "select  count(*) as cnt from position"; 
            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            String test = dr["cnt"].ToString();
            conn.Close();
            return test;
        }
    }
}
