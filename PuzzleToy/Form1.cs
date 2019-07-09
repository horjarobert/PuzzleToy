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
    public partial class Form1 : Form
    {
        int PanelAction;
        bool Hidden;

        public Form1()
        {
            InitializeComponent();

            PanelAction = hideShowPanel.Width;
            Hidden = false;
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            level11.BringToFront();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                hideShowPanel.Width = hideShowPanel.Width + 20;
                if(hideShowPanel.Width >= PanelAction)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                hideShowPanel.Width = hideShowPanel.Width - 20;
                if(hideShowPanel.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void showDDen_Click(object sender, EventArgs e)
        {
            if (Hidden)
                showDDen.Text = "H\n\n\nI\n\n\nD\n\n\nE";
            else
                showDDen.Text = "S\n\n\nH\n\n\nO\n\n\nW";
            timer1.Start();

        }

        private void level1_Click(object sender, EventArgs e)
        {
            level11.BringToFront();
        }

        private void level2_Click(object sender, EventArgs e)
        {
            level21.BringToFront();
        }

        private void level3_Click(object sender, EventArgs e)
        {
            level31.BringToFront();
        }

        private void level4_Click(object sender, EventArgs e)
        {
            level41.BringToFront();
        }

        private void level5_Click(object sender, EventArgs e)
        {
            level51.BringToFront();
        }

        private void showDDen_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.showDDen, "Click me!");
        }

        private void level1_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.level1, "Click!");
        }

        private void level2_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.level2, "Click!");
        }

        private void level3_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.level3, "Click!");
        }

        private void level4_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.level4, "Click!");
        }

        private void level5_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.level5, "Click!");
        }

        private void titleTxt_MouseHover(object sender, EventArgs e)
        {
            ToolTip fun = new ToolTip();
            fun.SetToolTip(this.titleTxt, "Have fun!");
        }

        private void infoBtn_MouseHover(object sender, EventArgs e)
        {
            ToolTip click = new ToolTip();
            click.SetToolTip(this.infoBtn, "Click!");
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            info form = new info();
            form.SetDesktopLocation(448, 350);
            form.Show();
        }
    }
}
