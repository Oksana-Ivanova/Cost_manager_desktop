using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desktop
{
    class secondary_methods
    {
        public static string generator()
        {
            Random rnd = new Random();
            long part_1 = rnd.Next(100000000, 999999999);
            long part_2 = rnd.Next(100, 999);
            return Convert.ToString(Convert.ToInt64(Convert.ToString(part_1) + Convert.ToString(part_2)), 16);
        }
        public static string datetime_to_sql_format(DateTime date)
        { return date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString() + " " + date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString(); }
        public static string date()
        {
            DateTime date = new DateTime();
            date = DateTime.UtcNow.AddHours(3);
            return date.Year.ToString() + "." + date.Month.ToString() + "." + date.Day.ToString() + " " + date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();
        }
        public static string date_transform_to_sql_date(string date, int n)
        {
            //MessageBox.Show(date);
            try { 
            return date.Substring(6, 4) + "." + date.Substring(3, 2) + "." + date.Substring(0, 2) + " " + date.Substring(10, n);}
            catch
            {return "0";}
        }
        public static void set_sum(int index,string cost_type_id )
        {
            try
            {

                List<string> list = new List<string>();
                
           /*     string qry = "select sum(price) from costs where user_id=" + LoginForm.user_ID + " and cost_type_id='" + cost_type_id + "'";
                dataGridView1.Rows[index].Cells["sum"].Value = SqlFunction.get(qry, out list).ToArray()[0].ToString();*/
            }
            catch { }
        }
        public static void set_value(int index)
        {
            try
            {
                /*List<string> list = new List<string>();
                string limit_id = (dataGridView1.Rows[index].Cells["limit_id"].Value.ToString());
                string qry = "select value from limits where id='" + limit_id + "'";
                dataGridView1.Rows[index].Cells["value"].Value = SqlFunction.get(qry, out list).ToArray()[0].ToString();*/
            }
            catch { }
        }
        public static string get_most_often_cost(out double sum,out string cost_type_id)
        {
            const string host = "127.0.0.1";
            const string database = "heroku_9e3361f1a2a704a";
            const string user = "root";
            const string password = "123";

            DateTime period_begin_date = DateTime.Today.AddDays(-6);
            DateTime period_end_date = DateTime.Today.AddDays(1);

            cost_type_id="";
            DBHandler controller = new DBHandler(host, database, user, password);
            List<Cost> List_often = new List<Cost>();
            List<int> number_of_costs = new List<int>();
            int n = 0, i = 0; string name = ""; string type_id = "";
           // Dictionary<string, int> dict = new Dictionary<string, int>();

            List<CostType> categoryName = new List<CostType>();
            categoryName = controller.getCategoriesByUserID(LoginForm.user_ID);

            categoryName.ForEach(delegate(CostType cost_type)
            {

                //  if (dict.ContainsKey<cost.CostTypeId.ToString()>) { dict.Add(cost.CostTypeId, 1); }
                List_often = controller.getAllCostsBySelectedPeriodAndCosTypeID(cost_type.Id, period_begin_date, period_end_date);
                number_of_costs.Add(List_often.Count);
                if (List_often.Count == number_of_costs.Max()) { n = i; name = cost_type.Name; type_id = cost_type.Id; }
                List_often.Clear();
                i++;
            });            
            cost_type_id = type_id;
            sum = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_end_date);
            return name;
        }
        public static string get_biggest_cost(out double sum, out string cost_type_id)
        {
            const string host = "127.0.0.1";
            const string database = "heroku_9e3361f1a2a704a";
            const string user = "root";
            const string password = "123";

            DateTime period_begin_date = DateTime.Today.AddDays(-6);
            DateTime period_end_date = DateTime.Today.AddDays(1);

            cost_type_id = "";
            DBHandler controller = new DBHandler(host, database, user, password);           
            List<double> sum_of_costs = new List<double>();
            double Sum = 0;
            int n = 0, i = 0; string name = ""; string type_id = "";
            // Dictionary<string, int> dict = new Dictionary<string, int>();

            List<CostType> categoryName = new List<CostType>();
            categoryName = controller.getCategoriesByUserID(LoginForm.user_ID);

            categoryName.ForEach(delegate(CostType cost_type)
            {

                //  if (dict.ContainsKey<cost.CostTypeId.ToString()>) { dict.Add(cost.CostTypeId, 1); }
               
                sum_of_costs.Add(controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type.Id, period_begin_date, period_end_date));
                if (sum_of_costs.Max() > Sum) { n = i; Sum = sum_of_costs.Max(); name = cost_type.Name; type_id = cost_type.Id; }              
               
                i++;
            }); 
            cost_type_id = type_id;
            sum = controller.get_sum_from_cost_by_date_and_cost_type_id(cost_type_id, period_begin_date, period_end_date);
            return name;
        }   
    }
}
