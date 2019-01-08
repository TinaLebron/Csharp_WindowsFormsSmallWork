using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWLottery.Src.Database
{
    public class DBHelper
    {
        //連線類別
        SqlConnection con;
        //連線參數
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Resources\Database.mdf; Integrated Security=True;Connect Timeout=30";

        public DBHelper()
        {
            int star = 6;
            int hitCount = 4;
            int rate = 0;



            OpenDB();

            rate = QueryBingoRate(star, hitCount);
            Console.WriteLine("star {0} , hitCount {1} , rate = {2}", star, hitCount, rate);

            CloseDB();
        }

        private int QueryBingoRate(int star, int hitCount)
        {
            SqlCommand cmd = null;
            SqlDataReader dataReader = null;
            string sql = "select rate from Bonus where star = " + star + " and hitCount = " + hitCount;
            int result = -1;

            try
            {
                cmd = new SqlCommand(sql, con);

                if (CheckConnection())
                    dataReader = cmd.ExecuteReader();
                else
                    return result;

                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader.GetValue(0));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("query exception : " + ex);
                throw;
            }

            return result;
        }

        //檢查連線狀態
        private bool CheckConnection()
        {
            bool isConnected = false;

            if (con.State == ConnectionState.Open)
                isConnected = true;

            return isConnected;
        }

        //關閉連線
        private bool CloseDB()
        {
            bool isClosed = false;

            try
            {
                if (con != null)
                    con.Close();
                Console.WriteLine("Connection Closed  !");
            }
            catch (Exception)
            {
                Console.WriteLine("Close failed !");
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Closed)
                {
                    isClosed = true;
                }
            }
            return isClosed;
        }

        //開啟連線
        private bool OpenDB()
        {
            bool isOpen = false;

            try
            {
                if (con == null)
                {
                    con = new SqlConnection(connectionString);
                }

                con.Open();
                Console.WriteLine("Connection Open  !");
            }
            catch (Exception)
            {
                Console.WriteLine("Open failed !");
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    isOpen = true;
                }
            }

            return isOpen;
        }
    }
}
