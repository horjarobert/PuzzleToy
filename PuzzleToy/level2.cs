using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PuzzleToy
{
    public partial class level2 : UserControl
    {
        public level2()
        {
            InitializeComponent();
        }

        private void fin1_DragDrop(object sender, DragEventArgs e)
        {
            fin1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();

        }

        private void fin1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin2_DragDrop(object sender, DragEventArgs e)
        {
            fin2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();

        }

        private void fin2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin3_DragDrop(object sender, DragEventArgs e)
        {
            fin3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();

        }

        private void fin3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin4_DragDrop(object sender, DragEventArgs e)
        {
            fin4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();

        }

        private void fin4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin5_DragDrop(object sender, DragEventArgs e)
        {
            fin5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();

        }

        private void fin5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin6_DragDrop(object sender, DragEventArgs e)
        {
            fin6.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();
        }

        private void fin6_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void level2_Load(object sender, EventArgs e)
        {
            fin1.AllowDrop = true;
            fin2.AllowDrop = true;
            fin3.AllowDrop = true;
            fin4.AllowDrop = true;
            fin5.AllowDrop = true;
            fin6.AllowDrop = true;
        }

        private void misc1_MouseDown(object sender, MouseEventArgs e)
        {
            misc1.DoDragDrop(misc1.Image, DragDropEffects.Copy);

        }

        private void misc2_MouseDown(object sender, MouseEventArgs e)
        {
            misc2.DoDragDrop(misc2.Image, DragDropEffects.Copy);


        }

        private void misc3_MouseDown(object sender, MouseEventArgs e)
        {
            misc3.DoDragDrop(misc3.Image, DragDropEffects.Copy);

        }

        private void misc4_MouseDown(object sender, MouseEventArgs e)
        {
            misc4.DoDragDrop(misc4.Image, DragDropEffects.Copy);

        }

        private void misc5_MouseDown(object sender, MouseEventArgs e)
        {
            misc5.DoDragDrop(misc5.Image, DragDropEffects.Copy);

        }

        private void misc6_MouseDown(object sender, MouseEventArgs e)
        {
            misc6.DoDragDrop(misc6.Image, DragDropEffects.Copy);

        }

        public void Correct()
        {
            if ((fin1.Image == misc1.Image) && (fin2.Image == misc6.Image) && (fin3.Image == misc4.Image) && (fin4.Image == misc3.Image) && (fin5.Image == misc5.Image) && (fin6.Image == misc2.Image))
            {
                MessageBox.Show("Congratulations!", "Level 2 completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hint2 form = new hint2();
            form.SetDesktopLocation(448, 350);
            form.Show();
            Thread.Sleep(2000);
            form.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

            ToolTip infos = new ToolTip();
            infos.IsBalloon = true;
            infos.ToolTipTitle = "[Hint]";
            infos.SetToolTip(this.pictureBox1, "Click for 2 seconds of hints");
        }

        private void misc1_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc1, "Drag");
        }

        private void misc2_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc2, "Drag");
        }

        private void misc3_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc3, "Drag");
        }

        private void misc4_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc4, "Drag");
        }

        private void misc5_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc5, "Drag");
        }

        private void misc6_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc6, "Drag");
        }

        private void fin1_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin1, "Drop");
        }

        private void fin2_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin2, "Drop");
        }

        private void fin3_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin3, "Drop");
        }

        private void fin4_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin4, "Drop");
        }

        private void fin5_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin5, "Drop");

        }

        private void fin6_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin6, "Drop");
        }
    }
}
