using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopGames
{
    public struct Game
    {
        public string name;
        public string style;
        public string mode;
        public int price;
        public PictureBox pb;
        public Label lbl;

        public Game(string _name, string _style, string _mode, int _price)
        {
            name = _name;
            style = _style;
            mode = _mode;
            price = _price;
            pb = new PictureBox();
            pb.Load("../../Pictures/" + name + ".jpg");
            lbl = new Label();
            lbl.Text = name;
        }

    }

    public partial class MainForm : Form
    {
        Game[] game_list = new Game[5];
        public MainForm()
        {
            InitializeComponent();
            FiltrPanel.Height = HideButton.Height;

            game_list[0] = new Game("Half-Life", "Шутер от первого лица", "однопользовательский", 200);
            game_list[1] = new Game("Dota2", "Стратегия", "многопользовательский", 300);
            game_list[2] = new Game("Mafia 2", "Приключение", "однопользовательский", 100);
            game_list[3] = new Game("Assassin's Creed II", "Приключение", "однопользовательский", 400);
            game_list[4] = new Game("S.T.A.L.K.E.R.: Call of Pripyat", "Ролевая игра", "однопользовательский", 500);

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height>HideButton.Height)
            {
                FiltrPanel.Height = HideButton.Height;
                HideButton.Text = "Развернуть";
            }
            else
            {
                FiltrPanel.Height = 125;
                HideButton.Text = "Свернуть";
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            PersForm persForm = new PersForm(pb.Tag.ToString());
            persForm.ShowDialog();
        }
    }
}
