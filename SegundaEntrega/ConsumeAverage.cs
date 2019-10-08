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
    public partial class ConsumeAverage : Form
    {
        Users users_stack;
        public ConsumeAverage(Users users_stack)
        {
            this.users_stack = users_stack;
            InitializeComponent();
        }

        private void ConsumeAverage_Load(object sender, EventArgs e)
        {
            float average = users_stack.calculateConsumeAverage();
            string average_str = users_stack.calculateConsumeAverage().ToString() + "Kw";
            if (float.IsNaN(average))
            {
                average_str = "No hay datos registrados.";
            }
            lblAverage.Text = average_str;
        }
    }
}
