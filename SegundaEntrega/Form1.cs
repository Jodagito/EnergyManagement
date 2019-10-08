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
        Form2 register_form;
        BillValue bill_value;
        ConsumeAverage consume_average;
        DiscountsTotal discounts_total;
        SavePerStratum save_per_stratum;
        GoalOverpast goal_overpast;
        public Form1()
        {
            register_form = new Form2(stored_users, users_stack);
            users_stack = new Users(stored_users);
            bill_value = new BillValue(stored_users);
            consume_average = new ConsumeAverage(users_stack);
            discounts_total = new DiscountsTotal(users_stack);
            save_per_stratum = new SavePerStratum(users_stack);
            goal_overpast = new GoalOverpast(users_stack);
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register_form.Close();
            register_form = new Form2(stored_users, users_stack);
            register_form.MdiParent = this;
            register_form.Show();
        }

        private void valorFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill_value.Close();
            bill_value = new BillValue(stored_users);
            bill_value.MdiParent = this;
            bill_value.Show();
        }

        private void promedioConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consume_average.Close();
            consume_average = new ConsumeAverage(users_stack);
            consume_average.MdiParent = this;
            consume_average.Show();
        }

        private void totalDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            discounts_total.Close();
            discounts_total = new DiscountsTotal(users_stack);
            discounts_total.MdiParent = this;
            discounts_total.Show();
        }

        private void ahorroPorEstratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_per_stratum.Close();
            save_per_stratum = new SavePerStratum(users_stack);
            save_per_stratum.MdiParent = this;
            save_per_stratum.Show();
        }

        private void superaronLaMetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goal_overpast.Close();
            goal_overpast = new GoalOverpast(users_stack);
            goal_overpast.MdiParent = this;
            goal_overpast.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.Wheat;
            MessageBox.Show("Bienvenido, para continuar por favor registre un usuario");
            register_form.MdiParent = this;
            register_form.Show();
        }
    }
}
