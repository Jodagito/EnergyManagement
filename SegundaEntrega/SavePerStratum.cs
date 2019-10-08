using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaEntrega
{
    public partial class SavePerStratum : Form
    {
        Users users_stack;
        public SavePerStratum(Users users_stack)
        {
            this.users_stack = users_stack;
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string stratum = txtStratum.Text;
            if (int.Parse(stratum) > 0 && int.Parse(stratum) <= 6)
            {
                float saved_percentage = users_stack.savePercentagePerStratum(stratum);
                string saved_percentage_str = users_stack.savePercentagePerStratum(stratum).ToString();
                if (float.IsNaN(saved_percentage))
                {
                    saved_percentage_str = "0";
                }
                lblSavedPercentage.Text = saved_percentage_str + "%";
            }
            else
            {
                MessageBox.Show("El estrato debe ser mayor a cero y menor o igual a seis.");
                txtStratum.Text = "";
                lblSavedPercentage.Text = "";
            }
        }
    }
}
