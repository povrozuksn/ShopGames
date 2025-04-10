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
        public static List<Game> selected_games = new List<Game>();

        public SelectedForm()
        {
            InitializeComponent();
            Text = "Избраное пользователя: " + AuthForm.name + " " + AuthForm.family;

            int x = 20;
            int y = 50;
            for(int i=0; i<selected_games.Count; i++)
            {
                #region 1 столбец (Обложка)
                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, y);
                pic.Size = new Size(200, 200);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = selected_games[i].pb.Image;
                Controls.Add(pic);
                #endregion

                #region 2 столбец (Параметры)
                Label name_label = new Label();
                name_label.Location = new Point(x+250, y);
                name_label.Size = new Size(300, 20);
                name_label.BorderStyle = BorderStyle.Fixed3D;
                name_label.Text = "Название: " + selected_games[i].name;
                Controls.Add(name_label);

                Label style_label = new Label();
                style_label.Location = new Point(x+250, y+30);
                style_label.Size = new Size(300, 20);
                style_label.Text = "Жанр: " + selected_games[i].style;
                Controls.Add(style_label);

                Label mode_label = new Label();
                mode_label.Location = new Point(x + 250, y + 60);
                mode_label.Size = new Size(300, 20);
                mode_label.Text = "Режим: " + selected_games[i].mode;
                Controls.Add(mode_label);
                #endregion

                #region 3 столбец (Цена)
                Label price_label = new Label();
                price_label.Location = new Point(x + 650, y);
                price_label.Size = new Size(150, 20);
                price_label.Text = "Цена: " + selected_games[i].price.ToString();
                Controls.Add(price_label);
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
    }
}
