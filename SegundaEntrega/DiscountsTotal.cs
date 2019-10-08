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
    public partial class DiscountsTotal : Form
    {
        Users users_stack;
        public DiscountsTotal(Users users_stack)
        {
            this.users_stack = users_stack;
            InitializeComponent();
        }

        private void DiscountsTotal_Load(object sender, EventArgs e)
        {
            float incentives_total = users_stack.calculateTotalIncentives();
            string incentives_total_str = users_stack.calculateTotalIncentives().ToString();
            if (float.IsNaN(incentives_total))
            {
                incentives_total_str = "0";
            }
            lblDiscount.Text = incentives_total_str;
        }
    }
}
