using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    class SqlFunction
    {

         private MySqlConnection _Connection;
         private string _Host;
         private string _Database;
         private string _AccountName;
         private string _Password;

         public SqlFunction(string host,
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
        

         MySqlDataAdapter adap;
         DataSet ds;



        public  void start()
        {
            try
            {               
                
                adap = new MySqlDataAdapter("SELECT *  FROM cost_types where user_id=  " + LoginForm.user_ID, _Connection);

                ds = new System.Data.DataSet();
                adap.Fill(ds, "cost_type");

                ds.Tables["cost_type"].Columns.Add("value");
                ds.Tables["cost_type"].Columns.Add("sum");
                ds.Tables["cost_type"].Columns["user_id"].DefaultValue = LoginForm.user_ID;

            }
            catch { }
            finally { _Connection.Close(); }
        }
        public  void Insert_into_cost_type(string id, int ID_user, double limit, string type_name, string Date)//cost_types
        {
            string ID_limit = create_limit(limit);          
            try
            {
                string qry = " insert into  heroku_9e3361f1a2a704a.cost_types values('" + id + "','" + ID_user + "','" + ID_limit + "','" + type_name + "','" + Date + "','" + Date + "')";
                MessageBox.Show(qry);
                _Connection.Open();
                MySqlCommand comandInsert = new MySqlCommand(qry,  _Connection);
                comandInsert.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { _Connection.Close(); }

        }
        private string create_limit(double limit) 
        {
            const string host = "127.0.0.1";
            const string database = "heroku_9e3361f1a2a704a";
            const string user = "root";
            const string password = "123";

            SqlFunction connect = new SqlFunction(host, database, user, password);          
            //string id = connect.generator_id(table_name, column_name);
            string id = SequenceGenerator.GenerateUniqueString();
            string Date = secondary_methods.date();
            try
            {
                string qry = " insert into  heroku_9e3361f1a2a704a.limits values('" + id + "','"+LoginForm.user_ID+" ','Another','" + limit + "','" + Date + "','" + Date + "')";
                MessageBox.Show(qry);
                _Connection.Open();
                MySqlCommand comandInsert = new MySqlCommand(qry, _Connection);
                comandInsert.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { _Connection.Close(); }
            return id;
        }
        public  void Insert_into_cost(string id, int ID_user, string ID_cost_type, string name, string description, double money, string Date)//costs
        {
                                
            try
            {
                string qry = "insert into heroku_9e3361f1a2a704a.costs values('" + id + "','" + ID_user + "','" + ID_cost_type + "','" + name + "','" + description + "','" + money + "','" + Date + "','" + Date + "')";
                 _Connection.Open();
                 MySqlCommand comandInsert = new MySqlCommand(qry, _Connection);
                comandInsert.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally {  _Connection.Close(); }

        }
        public void Insert_into_income(string id, int ID_user,  string name, string description, double money, string Date)//costs
        {

            try
            {
                string qry = "insert into heroku_9e3361f1a2a704a.incomes values('" + id + "','" + ID_user + "','" + name + "','" + description + "','" + money + "','" + Date + "','" + Date + "')";
                _Connection.Open();
                MySqlCommand comandInsert = new MySqlCommand(qry, _Connection);
                comandInsert.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { _Connection.Close(); }

        }
         public void refesh()
        {
            ds = new System.Data.DataSet();
            adap.Fill(ds, "cost_type");
            ds.Tables["cost_type"].Columns.Add("value");
            ds.Tables["cost_type"].Columns.Add("sum");
        }
        public  void Delete(string id, int ID_user, string type_name)//costs_types
        {
            try
            {
                string qry = " delete from  cost_types where id='" + id + "'  and name='" + type_name + "' and user_id='" + ID_user + "'";
                 _Connection.Open();
                MessageBox.Show(qry);
                MySqlCommand comandDelete = new MySqlCommand(qry, _Connection);
                comandDelete.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally
            {
                string qry = " delete from  costs where cost_type_id='" + id + "' and user_id='" + ID_user + "'";
                MessageBox.Show(qry);
                MySqlCommand comandDelete = new MySqlCommand(qry, _Connection);
                 _Connection.Close();
            }

        }
        public  void Delete(string id, string ID_cost, int ID_user)//costs
        {
            try
            {
                // string qry = " delete from costs where  user_id='" + Form2.ID + "'";
                string qry = " delete from costs where cost_type_id='" + ID_cost + "' and user_id='" + ID_user + "' and id='" + id + "'";
                 _Connection.Open();
                MessageBox.Show(qry);
                MySqlCommand comandDelete = new MySqlCommand(qry, _Connection);
                comandDelete.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally {  _Connection.Close(); }

        }
        public  DataSet drow_dataGridViewOutlays(string ID_cost)
        {
            MySqlDataAdapter adap1 = new MySqlDataAdapter("select * from costs where cost_type_id='" + ID_cost + "and user_id='" + LoginForm.user_ID + "'",  _Connection);
            // MySqlDataAdapter adap1 = new MySqlDataAdapter("select * from costs where cost_type_id='" + ID_cost + "'", con);
            DataSet dt = new DataSet();
            adap1.Fill(dt, "costs");
            return dt;
        }
        public  void Update(string id, int ID_user, string ID_limit, string type_name, string Date_create, string Date_updadate)//cost_types
        {

            try
            {
                // {string qry="update heroku_9e3361f1a2a704a.cost_types set name='dd', limit_id='ac59dddaf4', updated_at='2014-05-04 15:43:24' where  user_id= '2'  and id='7f84e3df3f' and created_at='2014-05-04 09:21:24'";
                string qry = "update cost_types set name='" + type_name + "', limit_id='" + ID_limit + "', updated_at='" + Date_updadate + "' where  user_id='" + ID_user + "' and id='" + id + "' and created_at='" + Date_create + "';";
                 _Connection.Open(); MessageBox.Show(qry);
                 MySqlCommand comandUpdate = new MySqlCommand(qry, _Connection);
                comandUpdate.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally {  _Connection.Close(); }
        }
        public  void Update(string id, int ID_user, string ID_cost, string cost_name, string description, double money, string Date_create, string Date_updadate) //costs
        {

            try
            {//               update heroku_9e3361f1a2a704a.costs set name='aa', description='aa', updated_at='2014-05-04 18:09:45' where  user_id='2' and id='bf9cb1879f' and created_at='2014-05-04 10:23:48' and cost_type_id='4e7c064431';
                string qry = "update costs set name='" + cost_name + "', description='" + description + "', updated_at='" + Date_updadate + "' where  user_id='" + ID_user + "' and id='" + id + "' and created_at='" + Date_create + "' and cost_type_id='" + ID_cost + "';";
                 _Connection.Open(); MessageBox.Show(qry);
                 MySqlCommand comandUpdate = new MySqlCommand(qry, _Connection);
                comandUpdate.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally {  _Connection.Close(); }
        }
      // public bool get_id_from_table() { }
        public string generator_id(string table_name, string column_name)
        {
            string genereted_id;
          bool b = false;
          _Connection.Open();
          MySqlCommand mysqlQuery = _Connection.CreateCommand();
          do
          {
              genereted_id = secondary_methods.generator();
              mysqlQuery.CommandText = "SELECT * FROM " + table_name + " WHERE " + column_name + "='" + genereted_id + "';";
              MySqlDataReader mysqlResult = mysqlQuery.ExecuteReader();
              while (mysqlResult.Read())
              {
                  try
                  {
                      string id;
                      id = mysqlResult.GetString(0);
                      if (genereted_id.Contains(id)) b = true;
                  }
                  catch { }
              }
             
          } while (b);

          _Connection.Close();
          return genereted_id;
        }

        
        public static string UniqueIdGenerator()
        {
            long secondsCount = DateTime.Now.DayOfYear * 24 + DateTime.Now.Hour;
            secondsCount = secondsCount * 60 + DateTime.Now.Minute;
            secondsCount = secondsCount * 60 + DateTime.Now.Second;
            secondsCount = secondsCount * 1000 + DateTime.Now.Millisecond;
            
            string resultString = secondsCount.ToString("X").ToLower();

            while (resultString.Length < 10)
            {
                resultString = "0" + resultString;
            }

            return resultString;
        }

    }


}

