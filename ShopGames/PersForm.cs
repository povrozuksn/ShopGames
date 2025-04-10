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
    public partial class PersForm : Form
    {
        Game game;
        public PersForm(Game _game)
        {
            InitializeComponent();

            game = _game;

            if (AuthForm.login == "")
            {
                AddSelectButton.Visible = false;
            }
            else
            {
                AddSelectButton.Visible = true;
            }

                Text = game.name;
            NameLabel.Text = "Название игры: " + game.name;
            PersPictureBox.Image = game.pb.Image; 
            StyleLabel.Text = "Жанр игры: " + game.style;
            PriceLabel.Text = "Цена игры, руб. " + game.price;
            try
            {
                DeskTextBox.Text = File.ReadAllText("../../Pictures/" + game.name + ".txt");
            }
            catch (Exception) { }
        }

        private void AddSelectButton_Click(object sender, EventArgs e)
        {
            SelectedForm.selected_games.Add(game);
        }
    }
}
