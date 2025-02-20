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
    public partial class PersForm : Form
    {
        public PersForm(Game game)
        {
            InitializeComponent();

            Text = game.name;
            NameLabel.Text = "Название игры: " + game.name;
            PersPictureBox.Image = game.pb.Image; 
            StyleLabel.Text = "Жанр игры: " + game.style;
            PriceLabel.Text = "Цена игры, руб. " + game.price;
        }
    }
}
