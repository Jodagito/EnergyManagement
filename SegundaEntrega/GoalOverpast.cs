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
    public partial class GoalOverpast : Form
    {
        Users users_stack;
        public GoalOverpast(Users users_stack)
        {
            this.users_stack = users_stack;
            InitializeComponent();
        }

        private void GoalOverpast_Load(object sender, EventArgs e)
        {
            int users_overpast = users_stack.consumeBiggerThanGoal();
            string users_overpast_str = users_stack.consumeBiggerThanGoal().ToString();
            if (float.IsNaN(users_overpast))
            {
                users_overpast_str = "0";
            }
            lblOverpastUsers.Text = users_overpast_str;
        }
    }
}
