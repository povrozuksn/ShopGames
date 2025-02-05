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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FiltrPanel.Height = HideButton.Height;
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
            PersForm persForm = new PersForm();
            persForm.ShowDialog();
        }
    }
}
