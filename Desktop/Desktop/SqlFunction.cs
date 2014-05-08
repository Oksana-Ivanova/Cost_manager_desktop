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

        
     public  static MySqlConnection con= new MySqlConnection();       
        
       static MySqlDataAdapter adap;
       static DataSet ds;
       
        
      
        public static void start()
        {
            try
            {
                string connectionString = "Database=heroku_9e3361f1a2a704a;Data Source=127.0.0.1;User=root;Password=123";
                con.ConnectionString = connectionString;

                adap = new MySqlDataAdapter("SELECT *  FROM cost_types where user_id=  " + LoginForm.user_ID, con);

                ds = new System.Data.DataSet();
                adap.Fill(ds, "cost_type");

                ds.Tables["cost_type"].Columns.Add("value");
                ds.Tables["cost_type"].Columns.Add("sum");
                ds.Tables["cost_type"].Columns["user_id"].DefaultValue = LoginForm.user_ID;

            }
            catch { }
            finally { con.Close(); }
        }
        public static void Insert_into_cost_type(string id, int ID_user, string ID_limit, string type_name, string Date)//cost_types
        {
            string connectionString = "Database=heroku_9e3361f1a2a704a;Data Source=127.0.0.1;User=root;Password=123";
            con.ConnectionString = connectionString;
            try
            {
                string qry = " insert into  heroku_9e3361f1a2a704a.cost_types values('" + id + "','" + ID_user + "','" + ID_limit + "','" + type_name + "','" + Date + "','" + Date + "')";
                MessageBox.Show(qry);
                con.Open();
                MySqlCommand comandInsert = new MySqlCommand(qry, con);
                comandInsert.ExecuteNonQuery(); 
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { con.Close(); } 

        }
        public static void Insert_into_cost(string id, int ID_user, string ID_cost_type, string name, string description,double money, string Date)//costs
        {
          
            string connectionString = "Database=heroku_9e3361f1a2a704a;Data Source=127.0.0.1;User=root;Password=123";
            MessageBox.Show(connectionString);
            con.ConnectionString = connectionString;
            try
            {
                string qry = "insert into heroku_9e3361f1a2a704a.costs values('" + id + "','" + ID_user + "','" + ID_cost_type + "','" + name + "','" + description + "','" + money + "','" + Date + "','" + Date + "')";
                con.Open();
                MySqlCommand comandInsert = new MySqlCommand(qry, con);
                comandInsert.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { con.Close();  }

        }
        static public void refesh()
        {
            ds = new System.Data.DataSet();
            adap.Fill(ds, "cost_type");
            ds.Tables["cost_type"].Columns.Add("value");
            ds.Tables["cost_type"].Columns.Add("sum"); 
        }
        public static void Delete(string id, int ID_user, string type_name)//costs_types
        {
            try
            {
                string qry = " delete from  cost_types where id='" + id + "'  and name='" + type_name + "' and user_id='" + ID_user + "'";
                con.Open();
                MessageBox.Show(qry);
                MySqlCommand comandDelete = new MySqlCommand(qry, con);
                comandDelete.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally
            {
                string qry = " delete from  costs where cost_type_id='" + id + "' and user_id='" + ID_user + "'";
                MessageBox.Show(qry);
                MySqlCommand comandDelete = new MySqlCommand(qry, con);
                con.Close(); 
            }

        }
        public static void Delete(string id,  string ID_cost,int ID_user)//costs
        {
            try {
                // string qry = " delete from costs where  user_id='" + Form2.ID + "'";
                string qry = " delete from costs where cost_type_id='" + ID_cost + "' and user_id='" + ID_user + "' and id='" + id + "'";
                con.Open();
                MessageBox.Show(qry);
                MySqlCommand comandDelete = new MySqlCommand(qry, con);
                comandDelete.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { con.Close(); }

        }
        public static DataSet drow_dataGridViewOutlays(string ID_cost)
        {
            MySqlDataAdapter adap1 = new MySqlDataAdapter("select * from costs where cost_type_id='" + ID_cost + "and user_id='" + LoginForm.user_ID+ "'", con);
            // MySqlDataAdapter adap1 = new MySqlDataAdapter("select * from costs where cost_type_id='" + ID_cost + "'", con);
            DataSet dt = new DataSet();
            adap1.Fill(dt, "costs");
            return dt;
        }
        public static void Update(string id, int ID_user, string ID_limit, string type_name, string Date_create, string Date_updadate)//cost_types
        {
           
                try{
                                // {string qry="update heroku_9e3361f1a2a704a.cost_types set name='dd', limit_id='ac59dddaf4', updated_at='2014-05-04 15:43:24' where  user_id= '2'  and id='7f84e3df3f' and created_at='2014-05-04 09:21:24'";
                                 string qry = "update cost_types set name='"+ type_name +"', limit_id='" + ID_limit + "', updated_at='" + Date_updadate + "' where  user_id='" + ID_user + "' and id='" + id + "' and created_at='" + Date_create + "';";
                    con.Open(); MessageBox.Show(qry);
                    MySqlCommand comandUpdate= new MySqlCommand(qry, con);
                    comandUpdate.ExecuteNonQuery();
                }
                catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
                finally { con.Close(); }        
        }
        public static void Update(string id, int ID_user, string ID_cost, string cost_name, string description,double money , string Date_create, string Date_updadate) //costs
        {
            
            try
            {//               update heroku_9e3361f1a2a704a.costs set name='aa', description='aa', updated_at='2014-05-04 18:09:45' where  user_id='2' and id='bf9cb1879f' and created_at='2014-05-04 10:23:48' and cost_type_id='4e7c064431';
                string qry = "update costs set name='" + cost_name + "', description='" + description + "', updated_at='" + Date_updadate + "' where  user_id='" + ID_user + "' and id='" + id + "' and created_at='" + Date_create + "' and cost_type_id='"+ID_cost+"';";
                con.Open(); MessageBox.Show(qry);
                MySqlCommand comandUpdate = new MySqlCommand(qry, con);
                comandUpdate.ExecuteNonQuery();
            }
            catch (MySqlException exeption) { MessageBox.Show(exeption.ToString()); }
            finally { con.Close(); }
        }
        public static void show() { MessageBox.Show("yes"); }
     
    }
}
