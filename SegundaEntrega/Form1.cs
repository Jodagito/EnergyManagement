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
    public partial class Form1 : Form
    {
        List<User> stored_users = new List<User>();
        Users users_stack;
        public Form1()
        {
            users_stack = new Users(stored_users);
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2(stored_users, users_stack);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void valorFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillValue newMDIChild = new BillValue(stored_users);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void promedioConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumeAverage newMDIChild = new ConsumeAverage(users_stack);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void totalDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountsTotal newMDIChild = new DiscountsTotal(users_stack);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ahorroPorEstratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePerStratum newMDIChild = new SavePerStratum(users_stack);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void superaronLaMetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoalOverpast newMDIChild = new GoalOverpast(users_stack);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2(stored_users, users_stack);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
