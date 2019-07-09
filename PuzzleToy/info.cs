using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleToy
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void info_Load(object sender, EventArgs e)
        {
            animation.AnimateWindow(this.Handle, 500, animation.VER_Negative);

        }

        private void X_MouseHover(object sender, EventArgs e)
        {
            ToolTip close = new ToolTip();
            close.SetToolTip(this.X, "Close");
        }

        private void closing_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closing_MouseHover(object sender, EventArgs e)
        {
            ToolTip close = new ToolTip();
            close.SetToolTip(this.X, "Close");
        }
    }
}
