using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class New_Incomes : Form
    {
        public New_Incomes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate fields on the form
        /// </summary>
        /// <returns>true if all fields on the form are filled correctly 
        /// and there are no empty eesential fields</returns>
        private bool validateFields()
        {
            if (tbTitleNewIncome.Text == String.Empty)
            {
                MessageBox.Show("Please fill cost name!", "Empty cost name.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            if (numValue.Value == Decimal.Zero)
            {
                MessageBox.Show("Please set cost value!", "Empty cost value.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validateFields() == false)
                return;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
