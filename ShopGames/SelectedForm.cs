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
    public partial class SelectedForm : Form
    {
        //public static List<Game> selected_games = new List<Game>();
        public static Dictionary<Game, int> selected_games = new Dictionary<Game, int>();

        public SelectedForm()
        {
            InitializeComponent();
            Text = "Избраное пользователя: " + AuthForm.name + " " + AuthForm.family;

            int x = 20;
            int y = 50;
            foreach(KeyValuePair<Game, int> selected_game in selected_games)
            {
                Game game = selected_game.Key;
                
                #region 1 столбец (Обложка)
                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, y);
                pic.Size = new Size(200, 200);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = game.pb.Image;
                Controls.Add(pic);
                #endregion

                #region 2 столбец (Параметры)
                Label name_label = new Label();
                name_label.Location = new Point(x+250, y);
                name_label.Size = new Size(300, 20);
                name_label.BorderStyle = BorderStyle.Fixed3D;
                name_label.Text = "Название: " + game.name;
                Controls.Add(name_label);

                Label style_label = new Label();
                style_label.Location = new Point(x+250, y+30);
                style_label.Size = new Size(300, 20);
                style_label.Text = "Жанр: " + game.style;
                Controls.Add(style_label);

                Label mode_label = new Label();
                mode_label.Location = new Point(x + 250, y + 60);
                mode_label.Size = new Size(300, 20);
                mode_label.Text = "Режим: " + game.mode;
                Controls.Add(mode_label);
                #endregion

                #region 3 столбец (Цена)
                Label price_label = new Label();
                price_label.Location = new Point(x + 650, y);
                price_label.Size = new Size(150, 20);
                price_label.Text = "Цена: " + game.price.ToString();
                Controls.Add(price_label);

                Label count_label = new Label();
                count_label.Location = new Point(x + 650, y + 30);
                count_label.Size = new Size(150, 20);
                count_label.Text = "Количество: ";
                Controls.Add(count_label);

                NumericUpDown count = new NumericUpDown();
                count.Location = new Point(x + 650, y + 50);
                count.Size = new Size(150, 30);
                count.Value = selected_game.Value;
                count.ValueChanged += new EventHandler(CountCanged);
                Controls.Add(count);

                #endregion

                #region 4 столбец (Кнопка удаления)
                Button del_btn = new Button();
                del_btn.Location = new Point(x+900, y+50);
                del_btn.Size = new Size(100, 30);
                del_btn.Text = "Удалить";
                Controls.Add(del_btn);
                #endregion

                y += 250;
            }
        }

        private void CountCanged(object sender, EventArgs e)
        {

        }
    }
}
