using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MySql Library
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Desktop_project
{
    class DBHandler
    {
        private MySqlConnection _Connection;
        private string _Host;
        private string _Database;
        private string _AccountName;
        private string _Password;

        public DBHandler(string host,
                         string database,
                         string accountName,
                         string password)
        {
            _Host      = host;
            _Database  = database;
            
            _AccountName  = accountName;
            _Password  = password;

            string ConnectionString = "Database=" + _Database + ";Datasource=" + _Host + ";User=" + _AccountName + ";Password=" + _Password;

            _Connection = new MySqlConnection(ConnectionString);
            _Connection.Open();

        }

        ~DBHandler()
        {
            _Connection.Close();
        }

        private uint getUserIdByName(string userName)
        {
            uint resultId = uint.MaxValue;
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT id Distinct(1) FROM users WHERE name =\"" + userName + "\";";
            
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
                        
            mysqlResult.Read();
            resultId = Convert.ToUInt32(mysqlResult.GetString(0));
    
            return resultId;        
        }
        private CostType getCategoryByName(string categoryName)
        {
            CostType resultCategory = null;
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT id Distinct(1) FROM cost_types WHERE name =\"" + categoryName + "\";";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            mysqlResult.Read();
            resultCategory.Id = Convert.ToUInt32(mysqlResult.GetString(0));
            resultCategory.Name = mysqlResult.GetString(1);
            resultCategory.CreateDate = Convert.ToDateTime(mysqlResult.GetString(2));
            resultCategory.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(3));

            return resultCategory;
        }

        public List<Cost> getAllCosts(string userName)
        {
            uint userId = getUserIdByName(userName);

            List<Cost> resultList = new List<Cost> ();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE user_id = " + userId + ";";
            
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            Cost tempObject = new Cost();
            while (mysqlResult.Read())
            {
                tempObject.Id           = Convert.ToUInt32(mysqlResult.GetString(0));
                tempObject.UserId       = Convert.ToUInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId   = Convert.ToUInt32(mysqlResult.GetString(2));
                tempObject.Name         = mysqlResult.GetString(3);
                tempObject.Description  = mysqlResult.GetString(4);
                tempObject.Price        = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate   = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate   = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            return resultList;
        }

        public List<Cost> getCostByName(string costName, string userName)
        {
            uint userId = getUserIdByName(userName);

            List<Cost> resultList = new List<Cost>();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE name =\"" + costName + "\" AND user_id = " + userId + ";";
           
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            Cost tempObject = new Cost();
            while (mysqlResult.Read())
            {
                tempObject.Id = Convert.ToUInt32(mysqlResult.GetString(0));
                tempObject.UserId = Convert.ToUInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = Convert.ToUInt32(mysqlResult.GetString(2));
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            return resultList;

        }

        public List<Cost> getCostByCategory(string categoryName, string userName)
        {
            uint userId = getUserIdByName(userName);
            uint categoryId = getCategoryByName(categoryName).Id;

            List<Cost> resultList = new List<Cost>();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE cost_type_id = \"" + categoryId + "\" AND user_id = " + userId + ";";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            Cost tempObject = new Cost();
            while (mysqlResult.Read())
            {
                tempObject.Id = Convert.ToUInt32(mysqlResult.GetString(0));
                tempObject.UserId = Convert.ToUInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = Convert.ToUInt32(mysqlResult.GetString(2));
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            return resultList;
        }
    
    }
}
