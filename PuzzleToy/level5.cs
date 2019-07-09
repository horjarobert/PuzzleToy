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
    public partial class level5 : UserControl
    {
        public level5()
        {
            InitializeComponent();
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

        private void misc7_MouseDown(object sender, MouseEventArgs e)
        {
            misc7.DoDragDrop(misc7.Image, DragDropEffects.Copy);

        }

        private void misc8_MouseDown(object sender, MouseEventArgs e)
        {
            misc8.DoDragDrop(misc8.Image, DragDropEffects.Copy);

        }

        private void misc9_MouseDown(object sender, MouseEventArgs e)
        {
            misc9.DoDragDrop(misc9.Image, DragDropEffects.Copy);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hint5 form = new hint5();
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

        public void Correct()
        {
            if ((fin1.Image == misc5.Image) && (fin2.Image == misc7.Image) && (fin3.Image == misc9.Image) && (fin4.Image == misc1.Image) && (fin5.Image == misc2.Image) && (fin6.Image == misc4.Image) && (fin7.Image == misc3.Image) && (fin8.Image == misc6.Image) && (fin9.Image == misc8.Image))
            {
                MessageBox.Show("Congratulations!", "Level 5 completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void level5_Load(object sender, EventArgs e)
        {
            fin1.AllowDrop = true;
            fin2.AllowDrop = true;
            fin3.AllowDrop = true;
            fin4.AllowDrop = true;
            fin5.AllowDrop = true;
            fin6.AllowDrop = true;
            fin7.AllowDrop = true;
            fin8.AllowDrop = true;
            fin9.AllowDrop = true;
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

        private void fin3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin3_DragDrop(object sender, DragEventArgs e)
        {
            fin3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
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

        private void fin7_DragDrop(object sender, DragEventArgs e)
        {
            fin7.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();
        }

        private void fin7_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin8_DragDrop(object sender, DragEventArgs e)
        {
            fin8.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();
        }

        private void fin8_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

        }

        private void fin9_DragDrop(object sender, DragEventArgs e)
        {
            fin9.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            Correct();
        }

        private void fin9_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;

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

        private void misc7_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc7, "Drag");
        }

        private void misc8_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc8, "Drag");
        }

        private void misc9_MouseHover(object sender, EventArgs e)
        {
            ToolTip drag = new ToolTip();
            drag.SetToolTip(this.misc9, "Drag");
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

        private void fin7_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin7, "Drop");
        }

        private void fin8_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin8, "Drop");
        }

        private void fin9_MouseHover(object sender, EventArgs e)
        {
            ToolTip drop = new ToolTip();
            drop.SetToolTip(this.fin9, "Drop");
        }
    }
}
