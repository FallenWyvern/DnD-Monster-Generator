using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Monster
{
    public partial class CustomSpeed : Form
    {
        public CustomSpeed()
        {
            InitializeComponent();
        }

        private void Save(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            SpeedDescription.Text = "";
            this.Close();
        }
    }
}
