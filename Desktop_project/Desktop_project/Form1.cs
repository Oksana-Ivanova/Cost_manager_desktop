using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_project
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
           
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Doh". При необходимости она может быть перемещена или удалена.
            this.dohTableAdapter.Fill(this.bDDataSet.Doh);

        }

       

protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
           if (keyData == Keys.Escape)
           {
               Application.Exit(); 
               return true;
           }
           return base.ProcessCmdKey(ref msg, keyData);
       
  
}
       


    }
}
