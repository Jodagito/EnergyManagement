using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaEntrega
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<User> stored_users = new List<User>();
            Users users_stack = new Users();
            Application.Run(new Form1(stored_users, users_stack));
            Application.Run(new Form2(users_stack));
        }
    }
}
