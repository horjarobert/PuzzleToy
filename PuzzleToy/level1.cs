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
    public partial class level1 : UserControl
    {
        public level1()
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
            Correct();

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

        private void level1_Load(object sender, EventArgs e)
        {
            fin1.AllowDrop = true;
            fin2.AllowDrop = true;
            fin3.AllowDrop = true;
            fin4.AllowDrop = true;
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

        public void Correct()
        {
            if ((fin1.Image == misc1.Image) && (fin2.Image == misc3.Image) && (fin3.Image == misc2.Image) && (fin4.Image == misc4.Image))
            {
                MessageBox.Show("Congratulations!", "Level 1 completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           

            ToolTip infos = new ToolTip();
            infos.IsBalloon = true;
            infos.ToolTipTitle = "[Hint]";
            infos.SetToolTip(this.pictureBox1, "Click for 2 seconds of hints");

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hint1 form = new hint1();
            form.SetDesktopLocation(448, 350);
            form.Show();
            Thread.Sleep(2000);
            form.Close();
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
    }
}
