using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//MySql Library
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Desktop
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
            _Host = host;
            _Database = database;

            _AccountName = accountName;
            _Password = password;

            string ConnectionString = "Database=" + _Database + ";Datasource=" + _Host + ";User=" + _AccountName + ";Password=" + _Password;

            _Connection = new MySqlConnection(ConnectionString);
        }

        public User getUserByName(string userName)
        {
            User resultUser = new User();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM users WHERE name =\"" + userName + "\" LIMIT 1 ;";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            try
            {
                if (mysqlResult.Read())
                {
                    resultUser.Id = mysqlResult.GetString(0);
                    resultUser.Name = mysqlResult.GetString(1);
                    resultUser.Email = mysqlResult.GetString(2);
                    resultUser.Pasword = mysqlResult.GetString(3);
                    resultUser.SignInCount = Convert.ToUInt16(mysqlResult.GetString(7));
                    resultUser.CreateDate = Convert.ToDateTime(mysqlResult.GetString(12));
                    resultUser.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(13));
                }
            }
            catch { }


            _Connection.Close();
            return resultUser;
        }

        public User getUserByEmail(string userEmail)
        {
            User resultUser = new User();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM users WHERE email =\"" + userEmail + "\" LIMIT 1 ;";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            try
            {
                if (mysqlResult.Read())
                {
                    resultUser.Id = mysqlResult.GetString(0);
                    resultUser.Name = mysqlResult.GetString(1);
                    resultUser.Email = mysqlResult.GetString(2);
                    resultUser.Pasword = mysqlResult.GetString(3);
                    resultUser.SignInCount = Convert.ToUInt16(mysqlResult.GetString(7));
                    resultUser.CreateDate = Convert.ToDateTime(mysqlResult.GetString(12));
                    resultUser.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(13));
                }
            }
            catch { }


            _Connection.Close();
            return resultUser;
        }

        public List<CostType> getCategoriesByUserID(int user_ID)
        {
            List<CostType> resultCategoryList = new List<CostType>();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT id, name, created_at, updated_at FROM cost_types WHERE user_id = \"" + user_ID + "\" ;";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            while (mysqlResult.Read())
            {
                CostType tempObject = new CostType();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.Name = mysqlResult.GetString(1);
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(2));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(3));

                resultCategoryList.Add(tempObject);
            }
            _Connection.Close();
            return resultCategoryList;
        }
        public CostType getCategoryByName(string categoryName)
        {
            CostType resultCategory = new CostType();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT id, name, created_at, updated_at FROM cost_types WHERE name = \"" + categoryName + "\" LIMIT 1;";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            if (mysqlResult.Read())
            {
                resultCategory.Id = mysqlResult.GetString(0);
                resultCategory.Name = mysqlResult.GetString(1);
                resultCategory.CreateDate = Convert.ToDateTime(mysqlResult.GetString(2));
                resultCategory.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(3));
            }

            _Connection.Close();
            return resultCategory;
        }

        public  DataSet getAllCosts( string ID_cost)
        {
            DataSet ds = new DataSet();
            _Connection.Open();
           
            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter("select * from costs where cost_type_id='" + ID_cost + "'", _Connection);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "costs");

            }
            catch { }
            finally { _Connection.Close(); }
            return ds;
        }
        public DataSet getAllCostsBySelectedPeriod(string ID_cost_type,DateTime period_begin_date,DateTime period_end_date)
        {
            DataSet ds = new DataSet();
            _Connection.Open();
            string period_begin = secondary_methods.datetime_to_sql_format(period_begin_date);
            string period_end = secondary_methods.datetime_to_sql_format(period_end_date.AddDays(1));
            try
            {
                //MySqlDataAdapter adap = new MySqlDataAdapter("select * from heroku_9e3361f1a2a704a.costs where cost_type_id='" + ID_cost + "'and created_at>'" + period_begin_date + "'and created_at<'" + period_end_date + "';", _Connection);
                MySqlDataAdapter adap = new MySqlDataAdapter("select * from  costs where cost_type_id='"+ID_cost_type+"'and created_at>'"+period_begin+"' and created_at<'"+period_end+"';",_Connection);
             // "select * from  heroku_9e3361f1a2a704a.costs where cost_type_id='7b9c73541a'and created_at>'2014-04-13 0:00:00' and created_at<'2014-05-10 0:00:00';"
                //  select * from  heroku_9e3361f1a2a704a.costs where cost_type_id='7b9c73541a'and created_at>'2014-04-13 00:00:00' and created_at<'2014-05-10 00:00:00'
                //MessageBox.Show("select * from  heroku_9e3361f1a2a704a.costs where cost_type_id='" + ID_cost + "'and created_at>'" + period_begin+ "' and created_at<'" + period_end + "';");
                ds = new System.Data.DataSet();
                adap.Fill(ds, "costs");

            }
            catch { }
            finally { _Connection.Close(); }
            return ds;
        }
        public List<Cost> getCostByName(string costName, string userName)
        {
            string userId = LoginForm.user_ID.ToString();

            List<Cost> resultList = new List<Cost>();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE name =\"" + costName + "\" AND user_id = " + userId + ";";
            //MessageBox.Show("SELECT * FROM costs WHERE name =\"" + costName + "\" AND user_id = " + userId + ";");
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            while (mysqlResult.Read())
            {
                Cost tempObject = new Cost();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.UserId = Convert.ToInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = mysqlResult.GetString(2);
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }
           // MessageBox.Show(resultList[1].ToString());
            _Connection.Close();
            return resultList;
        }

        public List<Cost> getCostByCategory(string categoryName, string userName)
        {
            
            string userId = LoginForm.user_ID.ToString();
            string categoryId = getCategoryByName(categoryName).Id;

            List<Cost> resultList = new List<Cost>();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE cost_type_id = \"" + categoryId + "\" AND user_id = " + userId + ";";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            while (mysqlResult.Read())
            {
                Cost tempObject = new Cost();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.UserId =  Convert.ToInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = mysqlResult.GetString(2);
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            _Connection.Close();
            return resultList;
        }

        public CostType getCostCategory(string costName, string userName)
        {
            CostType resultCategory = new CostType();

            List<Cost> costs = getCostByName(costName, userName);
            if (costs.Count < 1)
                return null;

            string userId = LoginForm.user_ID.ToString();
            string categoryId = costs[0].CostTypeId;
                                   
            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT id, name, created_at, updated_at FROM cost_types WHERE id = \"" + categoryId + "\" AND user_id = " + userId + "  LIMIT 1;";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            if (mysqlResult.Read())
            {
                resultCategory.Id = mysqlResult.GetString(0);
                resultCategory.Name = mysqlResult.GetString(1);
                resultCategory.CreateDate = Convert.ToDateTime(mysqlResult.GetString(2));
                resultCategory.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(3));
            }

            _Connection.Close();
            return resultCategory;

        }

        private string sqlDateString(DateTime date)
        {
            return date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString();
        }

        public List<Cost> getCostByDate(DateTime date, string userName)
        {
            string userId = LoginForm.user_ID.ToString();
            string dateString = sqlDateString(date);

            List<Cost> resultList = new List<Cost>();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE DATEDIFF(costs.updated_at, '" + dateString + "') = 0 AND user_id = " + userId + ";";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            while (mysqlResult.Read())
            {
                Cost tempObject = new Cost();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.UserId =  Convert.ToInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = mysqlResult.GetString(2);
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            _Connection.Close();
            return resultList;
        }

        public List<Cost> getCostsInPeriod(DateTime date1, DateTime date2, string userName)
        {
            List<Cost> resultList = new List<Cost>();

            if (date1.CompareTo(date2) > 0)
            {
                Console.WriteLine("Invalid time interval\n");
                return resultList;
            }

            string userId = LoginForm.user_ID.ToString();
            string dateString1 = sqlDateString(date1);
            string dateString2 = sqlDateString(date2);

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM costs WHERE ( DATEDIFF(costs.updated_at, '" + dateString1
                + "') >= 0  AND ( DATEDIFF(costs.updated_at, '" + dateString2 + "') <= 0 ) ) AND user_id = " + userId + ";";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            while (mysqlResult.Read())
            {
                Cost tempObject = new Cost();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.UserId =  Convert.ToInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = mysqlResult.GetString(2);
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            _Connection.Close();
            return resultList;
        }

        public void addNewCategory(CostType category, string userName)
        {
            

            string categoryId = "2c851fb306";
            string categoryName = category.Name;
            string createdAtString = sqlDateString(category.CreateDate);
            string updatedAtString = sqlDateString(category.UpdateDate);

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "INSERT INTO cost_types ( id, user_id, limit_id, name, created_at, updated_at) "
            + "VALUES ('" + categoryId + "', 21, 'ac59dddaf4', '" + categoryName + "', '" + createdAtString + "', '" + updatedAtString + "' );";

            int queryResult = mysqlQuery.ExecuteNonQuery();

     

           
        }
        public void addNewCost(CostType cost, string id, int ID_user, string ID_cost, string name, string description, double price, string Date, string connectionString)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connectionString;
            try
            {
                string qry = "insert into costs values('" + id + "','" + ID_user + "','" + ID_cost + "','" + name + "','" + description + "','" + price + "','" + Date + "','" + Date + "');";
                con.Open();
                MySqlCommand comandInsert = new MySqlCommand(qry, con);
                comandInsert.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { }
            finally { con.Close(); }

        }
        public CostType getCategoryByNameAndUserID(string categoryName)
        {
            CostType resultCategory = new CostType();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT id FROM cost_types WHERE name = \"" + categoryName + "\"and user_id=\"" + LoginForm.user_ID + "\" LIMIT 1;";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            
            if (mysqlResult.Read())
            {
                try
                {
                    resultCategory.Id = mysqlResult.GetString(0);
                }
                catch { }           
              
            }

            _Connection.Close();
            return resultCategory;
        }
        public double get_sum_from_cost_by_date_and_cost_type_id(string cost_type_id, DateTime period_begin_date, DateTime period_end_date) 
        {
            string period_begin = secondary_methods.datetime_to_sql_format(period_begin_date);
            string period_end = secondary_methods.datetime_to_sql_format(period_end_date);
            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "select sum(price) from costs where user_id=" + LoginForm.user_ID + " and cost_type_id='" + cost_type_id + "' and created_at>'" + period_begin + "' and created_at<'" + period_end + "';";
           // mysqlQuery.CommandText = "select sum(price) from costs where user_id=2 and cost_type_id='a33b437e46' and created_at>'2014-05-08 00:00:00'and created_at<'2014-05-09 00:00:00';";
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            double sum=0;
            while (mysqlResult.Read())
            {
                try
                {
                    sum = mysqlResult.GetDouble(0);
                }
                catch { }
            }            
            _Connection.Close(); 
            return sum;         
           
        }
        public DataSet getAllIncomesBySelectedPeriod(DateTime period_begin_date, DateTime period_end_date)
        {
            DataSet ds = new DataSet();
            _Connection.Open();
            string period_begin = secondary_methods.datetime_to_sql_format(period_begin_date);
            string period_end = secondary_methods.datetime_to_sql_format(period_end_date.AddDays(2));
            try
            {

                MySqlDataAdapter adap = new MySqlDataAdapter("select * from  heroku_9e3361f1a2a704a.incomes where user_id='" + LoginForm.user_ID + "' and created_at>'" + period_begin + "' and created_at<'" + period_end + "';", _Connection);
               // MessageBox.Show("select * from  heroku_9e3361f1a2a704a.incomes where user_id='" + LoginForm.user_ID + "'and created_at>'" + period_begin + "' and created_at<'" + period_end + "';");
                ds = new System.Data.DataSet();
                adap.Fill(ds, "incomes");

            }
            catch { }
            finally { _Connection.Close(); }
            return ds;
        }
        public double get_sum_from_all_cost_by_week( DateTime period_begin_date, DateTime period_end_date)
        {
            string period_begin = secondary_methods.datetime_to_sql_format(period_begin_date);
            string period_end = secondary_methods.datetime_to_sql_format(period_end_date.AddDays(1));
            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "select sum(price) from costs where user_id=" + LoginForm.user_ID + " and created_at>'" + period_begin + "' and created_at<'" + period_end + "';";
            // mysqlQuery.CommandText = "select sum(price) from costs where user_id=2 and cost_type_id='a33b437e46' and created_at>'2014-05-08 00:00:00'and created_at<'2014-05-09 00:00:00';";
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            double sum = 0;
            while (mysqlResult.Read())
            {
                try
                {
                    sum = mysqlResult.GetDouble(0);
                }
                catch { }
            }
            _Connection.Close();
            return sum;

        }
        public List<Cost> getAllCostsBySelectedPeriodAndCosTypeID(string ID_cost_type, DateTime period_begin_date, DateTime period_end_date)
        {
            List<Cost> resultList = new List<Cost>();
           
            _Connection.Open();
            string period_begin = secondary_methods.datetime_to_sql_format(period_begin_date);
            string period_end = secondary_methods.datetime_to_sql_format(period_end_date.AddDays(1));
           
        
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "select * from  costs where cost_type_id='" + ID_cost_type + "'and created_at>'" + period_begin + "' and created_at<'" + period_end + "';";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            while (mysqlResult.Read())
            {
                Cost tempObject = new Cost();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.UserId = Convert.ToInt32(mysqlResult.GetString(1));
                tempObject.CostTypeId = mysqlResult.GetString(2);
                tempObject.Name = mysqlResult.GetString(3);
                tempObject.Description = mysqlResult.GetString(4);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(5));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(6));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(7));

                resultList.Add(tempObject);
            }

            _Connection.Close();
            return resultList;
        }

        public List<Income> getIncomeByName(string incomeName, string userName)
        {
            string userId = LoginForm.user_ID.ToString();

            List<Income> resultList = new List<Income>();

            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "SELECT * FROM incomes WHERE name =\"" + incomeName + "\" AND user_id = " + userId + ";";

            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();

            while (mysqlResult.Read())
            {
                Income tempObject = new Income();
                tempObject.Id = mysqlResult.GetString(0);
                tempObject.UserId = Convert.ToInt32(mysqlResult.GetString(1));
                tempObject.Name = mysqlResult.GetString(2);
                tempObject.Description = mysqlResult.GetString(3);
                tempObject.Price = Convert.ToDouble(mysqlResult.GetString(4));
                tempObject.CreateDate = Convert.ToDateTime(mysqlResult.GetString(5));
                tempObject.UpdateDate = Convert.ToDateTime(mysqlResult.GetString(6));

                resultList.Add(tempObject);
            }

            _Connection.Close();
            return resultList;
        }
        public double get_limit_value_by_id(string limit_id)
        {
          
            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "select value from limits where id='" + limit_id + "'";
            // mysqlQuery.CommandText = "select sum(price) from costs where user_id=2 and cost_type_id='a33b437e46' and created_at>'2014-05-08 00:00:00'and created_at<'2014-05-09 00:00:00';";
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            double value = 0;
            while (mysqlResult.Read())
            {
                try
                {
                    value = mysqlResult.GetDouble(0);
                }
                catch { }
            }
            _Connection.Close();
            return value;

        }
        public string get_limit_id_by_cost_type_id(string cost_type_id)
        {
            _Connection.Open();
            MySqlCommand mysqlQuery = _Connection.CreateCommand();
            mysqlQuery.CommandText = "select limit_id from cost_types where id='" + cost_type_id + "'";
            
            MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
            string id="";
            while (mysqlResult.Read())
            {
                try
                {
                    id = mysqlResult.GetString(0);
                }
                catch { }
            }
            _Connection.Close();
            return id;
        }

    }
}
       

    

