using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FactZenith.db
{
    class DBServer
    {
        //static string host = "(localdb)\Projects";
        static string database = "dbZenith";
   
        //static string userId = "root";
        //static string password = "";
        //static string port = "3306";
        //Data Source=DESKTOP-MQM0GEB;Initial Catalog=db_zenith;Integrated Security=True

        public static string srtgProvider;
        public DataSet ds;
        private SqlCommand dataCmd;
        private SqlDataAdapter dataAdapter;
        //private SqlTransaction dataTransact;
        private SqlConnection connection;
        public string chaine = "Data Source=MAXMAKALU;Initial Catalog=db_zenith;Integrated Security=True";


        public bool OUvrirConnexion()
        {
            try
            {
                srtgProvider = "Data Source=(localdb)\\Projects;Initial Catalog=db_zenith;Integrated Security=True";
                connection = new SqlConnection(srtgProvider);
                connection.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void FermerConnexion()
        {
            connection.Close();
            connection.Dispose();
        }

        public DataSet ExecuteerDuDataSet(string sql)
        {
            try
            {
                ds = new DataSet();
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public SqlDataReader ExecuterDuReader(string sql)
        {
            try
            {
                SqlDataReader reader;
                dataCmd = new SqlCommand(sql, connection);
                reader = dataCmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void ExecuteNonQuery(string sql,string msg)
        {
            
            try
            {
                dataCmd = new SqlCommand(sql, connection);
                OUvrirConnexion();
                dataCmd.CommandType = CommandType.Text;
                dataCmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Confirmation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    FermerConnexion();
                }
            }
           
            
        }
    }
}
