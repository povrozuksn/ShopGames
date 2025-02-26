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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text!="" && familyTextBox.Text!="" && loginTextBox.Text!="" && passTextBox.Text!="")
            {
                if (passTextBox.Text == repassTextBox.Text)
                {
                    System.IO.File.AppendAllText("users.txt", nameTextBox.Text + ", " +
                                                            familyTextBox.Text + ", " +
                                                            loginTextBox.Text + ", " +
                                                            passTextBox.Text +
                                                            Environment.NewLine);
                    MessageBox.Show("Регистрация прошла успешно");
                    Close();
                }
                else 
                {
                    MessageBox.Show("Пароли не совпали");
                }
            }
            else
            {
                MessageBox.Show("Все поля формы обязательны для заполнения");
            }
            
        }
    }
}
