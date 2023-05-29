using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    internal static class Program
    {
        //public static MainForm mainForm = new MainForm();
        public static bool isSuccess = false;
        
        static void database()
        {
            String connectStr = "server=127.0.0.1;port=3306;user=root;password=!Lucifer031337;database=mylibrary;";
            MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                string sql = "select * from class";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                while (reader.Read())
                {
                  Console.WriteLine(reader.GetString("cno"));
                  Console.WriteLine(reader.GetString("cname"));
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            database();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            if(isSuccess)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
