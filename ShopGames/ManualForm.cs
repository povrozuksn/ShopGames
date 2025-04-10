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
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
            textBox1.Text = File.ReadAllText("admin_manual.txt");
        }
    }
}
