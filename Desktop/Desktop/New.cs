using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desktop
{
    class New
    {
        public static string generator()
        {
            Random rnd = new Random();
            long part_1 = rnd.Next(100000000, 999999999);
            long part_2 = rnd.Next(100, 999);
            return Convert.ToString(Convert.ToInt64(Convert.ToString(part_1) + Convert.ToString(part_2)), 16);
        }
        public static string date()
        {
            DateTime date = new DateTime();
            date = DateTime.UtcNow.AddHours(3);
            return date.Year.ToString() + "." + date.Month.ToString() + "." + date.Day.ToString() + " " + date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();
        }
        public static string date_transform_to_sql_date(string date, int n)
        {
            MessageBox.Show(date);
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
    }
}
