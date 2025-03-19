using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShopGames
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        string fileName = "";
        private void picButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pictureBox.Load(fileName);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text=="" || styleComboBox.Text=="" || modeComboBox.Text=="" || priceTextBox.Text=="")
            {
                MessageBox.Show("Все поля обязательны для заполнения");
                return;
            }

            File.AppendAllText("games.txt", nameTextBox.Text + ", " + 
                                            styleComboBox.Text + ", " + 
                                            modeComboBox.Text + ", " + 
                                            priceTextBox.Text +
                                            Environment.NewLine);

            if(fileName != "")
            {
                File.Copy(fileName, "../../Pictures/" + nameTextBox.Text + ".jpg");
            }
        }
    }
}
