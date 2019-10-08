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
    public partial class BillValue : Form
    {
        List<User> stored_users;
        User user;
        public BillValue(List<User> stored_users)
        {
            this.stored_users = stored_users;
            InitializeComponent();
        }

        public void getUserBillValue(string id_card)
        {
            foreach (User user in stored_users)
            {
                if (user.idCard == id_card)
                {
                    this.user = user;
                    lblBillValue.Text = user.calculateBill().ToString();
                    break;
                }
                else if (user == stored_users.Last())
                {
                    MessageBox.Show("No existe un usuario con esa cédula.");
                    txtIdCard.Text = "";
                    lblBillValue.Text = "";
                }
            }
            if (stored_users.Count() == 0)
            {
                MessageBox.Show("No existen usuarios registrados.");
                txtIdCard.Text = "";
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string id_card = txtIdCard.Text;
            getUserBillValue(id_card);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
