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
        public static List<Game> game_list = new List<Game>();
        public MainForm()
        {
            InitializeComponent();
            FiltrPanel.Height = HideButton.Height;
            NameLabel.Visible = false;
            adminManualButton.Visible = false;
            SelectedButton.Visible = false;
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
            for (int i=0; i<game_list.Count; i++)
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

            for (int i = 0; i < game_list.Count; i++)
            {
                game_list[i].pb.Visible = true;
                game_list[i].lbl.Visible = true;

                if(StyleComboBox.Text != "" && StyleComboBox.Text != game_list[i].style)
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lbl.Visible = false;
                }

                if (NameTextBox.Text != "" && !game_list[i].name.ToLower().Contains(NameTextBox.Text.ToLower()))
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lbl.Visible = false;
                }

                if (ModeComboBox.Text != "" && ModeComboBox.Text != game_list[i].mode)
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lbl.Visible = false;
                }

                if (PriceTextBox.Text != "" && Convert.ToInt32(PriceTextBox.Text) >= game_list[i].price)
                {
                    game_list[i].pb.Visible = false;
                    game_list[i].lbl.Visible = false;
                }


                if (game_list[i].pb.Visible)
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

        private void InfoPanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null, null);
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.ShowDialog();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (AuthButton.Text == "Войти")
            {
                AuthForm authForm = new AuthForm();
                authForm.ShowDialog();
                if (AuthForm.login != "")
                { 
                    NameLabel.Text = "Вы авторизовались как " + AuthForm.name + " " + AuthForm.family;
                    NameLabel.Visible = true;
                    adminManualButton.Visible = (AuthForm.isAdmin == true);
                    SelectedButton.Visible = true;
                    AuthButton.Text = "Выйти";                
                }
            }
            else 
            {
                AuthForm.isAdmin = false;
                NameLabel.Text = "";
                NameLabel.Visible = false;
                adminManualButton.Visible= false;
                SelectedButton.Visible = false;
                AuthButton.Text = "Войти";
                AuthForm.name = "";
                AuthForm.family = "";
                AuthForm.login = "";
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.isAdmin)
            {
                AddForm add = new AddForm();
                add.ShowDialog();
                MainForm_Load(null, null);
            }
            else 
            {
                MessageBox.Show("Добавлять объекты может только администратор");
            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.isAdmin)
            {
                DelForm del = new DelForm();
                del.ShowDialog();
                MainForm_Load(null, null);
            }
            else
            {
                MessageBox.Show("Удалять объекты может только администратор");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            game_list.Clear();
            string[] strs = System.IO.File.ReadAllLines("games.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Game game = new Game(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]));
                game_list.Add(game);
            }

            int x = 30;
            int y = 30;
            InfoPanel.Controls.Clear();

            for (int i = 0; i < game_list.Count; i++)
            {
                game_list[i].pb.Location = new Point(x, y);
                game_list[i].pb.Size = new Size(250, 243);
                game_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                game_list[i].pb.Tag = game_list[i].name;
                game_list[i].pb.Click += new EventHandler(picture_Click);
                InfoPanel.Controls.Add(game_list[i].pb);

                game_list[i].lbl.Location = new Point(x, y + 260);
                game_list[i].lbl.Size = new Size(250, 25);
                game_list[i].lbl.TextAlign = ContentAlignment.MiddleCenter;
                InfoPanel.Controls.Add(game_list[i].lbl);

                x += 300;
                if (x + 250 > InfoPanel.Width)
                {
                    x = 30;
                    y += 300;
                }
            }

        }

        private void adminManualButton_Click(object sender, EventArgs e)
        {
            ManualForm form = new ManualForm();
            form.Show();
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm form = new SelectedForm();
            form.ShowDialog();
        }
    }
}
