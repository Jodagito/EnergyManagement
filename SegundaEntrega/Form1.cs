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
        List<User> stored_users;
        Users users_stack;
        public Form1(List<User> stored_users, Users users_stack)
        {
            this.stored_users = stored_users;
            this.users_stack = users_stack;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido, para continuar por favor registre un usuario");
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            bool save = true;
            if (idCardTxt.Text == "" || stratumTxt.Text == "" || goalTxt.Text == "" || consumeTxt.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                save = false;
            }
            if (save)
            {
                foreach (User user in stored_users)
                {
                    if (user.idCard == idCardTxt.Text)
                    {
                        MessageBox.Show("Un usuario con esta cédula ya está registrado");
                        save = false;
                    }
                }
                string id_card = idCardTxt.Text;
                if (float.Parse(stratumTxt.Text) > 6 || float.Parse(stratumTxt.Text) < 1)
                {
                    MessageBox.Show("El estrato debe estar entre uno y seis");
                    save = false;
                }
                else if (float.Parse(goalTxt.Text) < 1)
                {
                    MessageBox.Show("La meta de consumo no puede ser negativa o igual a cero");
                    save = false;
                }
                else if (float.Parse(consumeTxt.Text) < 1)
                {
                    MessageBox.Show("El consumo actual no puede ser negativo o igual a cero");
                    save = false;
                }
                else if (save)
                {
                    string stratum = stratumTxt.Text;
                    float save_goal = float.Parse(goalTxt.Text);
                    float actual_consume = float.Parse(consumeTxt.Text);
                    User actual_user = new User(id_card, stratum, save_goal, actual_consume);
                    stored_users.Add(actual_user);
                    users_stack.registeredUsers = stored_users;
                }
            }
            clearBtn_Click(sender, e);
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idCardTxt.Text = "";
            stratumTxt.Text = "";
            goalTxt.Text = "";
            consumeTxt.Text = "";
        }
    }
}
