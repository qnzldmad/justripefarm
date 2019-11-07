using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Paractical07_re_
{
    public class LabourerHandler
    {

        public int addNewLabourer(MySqlConnection conn, Labourer labourer)
        {
            string sql = "INSERT INTO labourer (name, age, gender)"
                + " VALUES ('" + labourer.Name + "', " + labourer.Age
                + "   , '" + labourer.Gender + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public List<Labourer> getAllLabourer(MySqlConnection conn)
        {
            List<Labourer> listLabr = new List<Labourer>();
            string sql = "SELECT * FROM labourer";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;
            myReader = sqlComm.ExecuteReader();
            while (myReader.Read())
            {
                Labourer aLabr = new Labourer();
                aLabr.Id = (int)myReader.GetValue(0);
                aLabr.Name = (string)myReader.GetValue(1);
                aLabr.Age = (int)myReader.GetValue(2);
                aLabr.Gender = (string)myReader.GetValue(3);
                listLabr.Add(aLabr);
            }
            return listLabr;
        }
    }
}
