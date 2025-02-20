using ShopGames.Properties;
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
            try
            {
                pb.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }

            lbl = new Label();
            lbl.Text = name;
        }

    }

    public partial class MainForm : Form
    {
        Game[] game_list = new Game[6];
        public MainForm()
        {
            InitializeComponent();
            FiltrPanel.Height = HideButton.Height;

            game_list[0] = new Game("Half-Life", "Шутер", "однопользовательский", 200);
            game_list[1] = new Game("Dota2", "Стратегия", "многопользовательский", 300);
            game_list[2] = new Game("Mafia 2", "Приключения", "однопользовательский", 100);
            game_list[3] = new Game("Assassin's Creed II", "Приключения", "однопользовательский", 400);
            game_list[4] = new Game("S.T.A.L.K.E.R. Call of Pripyat", "Ролевая игра", "однопользовательский", 500);
            game_list[5] = new Game("Minecraft", "Песочница", "многопользовательский", 500);

            int x = 30;
            int y = 30;

            for (int i = 0; i < 6; i++)
            {
                game_list[i].pb.Location = new Point(x, y);
                game_list[i].pb.Size = new Size(250, 243);
                game_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                game_list[i].pb.Tag = game_list[i].name;
                game_list[i].pb.Click += new EventHandler(picture_Click);
                InfoPanel.Controls.Add(game_list[i].pb);

                game_list[i].lbl.Location = new Point(x, y+260);
                game_list[i].lbl.Size = new Size(250, 25);
                game_list[i].lbl.TextAlign = ContentAlignment.MiddleCenter;
                InfoPanel.Controls.Add(game_list[i].lbl);

                x += 300;
                if (x+250 > InfoPanel.Width)
                {
                    x = 30;
                    y += 300;
                }
            }
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
            for (int i=0; i<6; i++)
            {
                if(((PictureBox)sender).Tag == game_list[i].pb.Tag)
                {
                    PersForm persForm = new PersForm(game_list[i]);
                    persForm.ShowDialog();
                }                
            }            
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 30;
            int y = 30;

            for (int i = 0; i < 6; i++)
            {
                game_list[i].pb.Visible = true;
                game_list[i].lbl.Visible = true;

                if(StyleComboBox.Text != "" && StyleComboBox.Text != game_list[i].style)
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lbl.Visible = false;
                }





                if(game_list[i].pb.Visible)
                {
                    game_list[i].pb.Location = new Point(x, y);
                    game_list[i].lbl.Location = new Point(x, y + 260);
                    
                    x += 300;
                    if (x + 250 > InfoPanel.Width)
                    {
                        x = 30;
                        y += 300;
                    }
                }
            }

        }
    }
}
