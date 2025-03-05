using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGames
{
    public partial class AuthForm : Form
    {
        public static string name = "";
        public static string family = "";
        public static string login = "";
        public static bool isAdmin = false;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string[] strs = System.IO.File.ReadAllLines("users.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                if(AuthTextBox.Text == parts[2] && PasTextBox.Text == parts[3])
                {
                    name = parts[0];
                    family = parts[1];
                    login = parts[2];
                    isAdmin = (parts[4]=="1");
                    Close();
                    return;
                }
            }
            MessageBox.Show("Указан неверный логин/пароль");
        }
    }
}
