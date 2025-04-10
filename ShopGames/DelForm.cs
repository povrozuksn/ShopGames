using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGames
{
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
            for(int i=0; i<MainForm.game_list.Count; i++)
            {
                selectedComboBox.Items.Add(MainForm.game_list[i].name);
            }
        }

        private void selectedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTextBox.Text = selectedComboBox.Text;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Действительно ли Вы хотите удалить выбранный объект", "Уделение объекта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Delete("games.txt");
                for (int i = 0; i < MainForm.game_list.Count; i++)
                {
                    if (selectedTextBox.Text == MainForm.game_list[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("games.txt", MainForm.game_list[i].name + ", " +
                                                MainForm.game_list[i].style + ", " +
                                                MainForm.game_list[i].mode + ", " +
                                                MainForm.game_list[i].price +
                                                Environment.NewLine);
                    }
                }
                MessageBox.Show("Удаление прошло успешно");
                Close();
            }
        }
    }
}
