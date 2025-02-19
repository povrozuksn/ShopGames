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
        public PersForm(string name)
        {
            InitializeComponent();

            Text = name;
            NameLabel.Text = name;
            PersPictureBox.Load("../../Pictures/" + name + ".jpg");
        }
    }
}
