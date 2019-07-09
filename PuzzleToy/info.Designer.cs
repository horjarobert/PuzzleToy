namespace PuzzleToy
{
    partial class info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoTitle = new System.Windows.Forms.Label();
            this.barStat = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.oneLine = new System.Windows.Forms.Label();
            this.twoLine = new System.Windows.Forms.Label();
            this.threeLine = new System.Windows.Forms.Label();
            this.fourLine = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoTitle
            // 
            this.infoTitle.BackColor = System.Drawing.Color.Teal;
            this.infoTitle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.infoTitle.Font = new System.Drawing.Font("Noto Sans", 26.25F);
            this.infoTitle.ForeColor = System.Drawing.Color.White;
            this.infoTitle.Location = new System.Drawing.Point(190, 38);
            this.infoTitle.Name = "infoTitle";
            this.infoTitle.Size = new System.Drawing.Size(323, 50);
            this.infoTitle.TabIndex = 5;
            this.infoTitle.Text = "INFORMATION";
            this.infoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barStat
            // 
            this.barStat.BackColor = System.Drawing.Color.White;
            this.barStat.Location = new System.Drawing.Point(125, 97);
            this.barStat.Name = "barStat";
            this.barStat.Size = new System.Drawing.Size(450, 5);
            this.barStat.TabIndex = 7;
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Teal;
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.Font = new System.Drawing.Font("Noto Sans", 26.25F);
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(626, 11);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(61, 50);
            this.X.TabIndex = 8;
            this.X.Text = "X";
            this.X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseHover += new System.EventHandler(this.X_MouseHover);
            // 
            // oneLine
            // 
            this.oneLine.BackColor = System.Drawing.Color.Teal;
            this.oneLine.Cursor = System.Windows.Forms.Cursors.Cross;
            this.oneLine.Font = new System.Drawing.Font("Noto Sans", 18F);
            this.oneLine.ForeColor = System.Drawing.Color.White;
            this.oneLine.Location = new System.Drawing.Point(129, 149);
            this.oneLine.Name = "oneLine";
            this.oneLine.Size = new System.Drawing.Size(450, 50);
            this.oneLine.TabIndex = 9;
            this.oneLine.Text = "-drag from MISCELLANEOUS to FINAL";
            this.oneLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // twoLine
            // 
            this.twoLine.BackColor = System.Drawing.Color.Teal;
            this.twoLine.Cursor = System.Windows.Forms.Cursors.Cross;
            this.twoLine.Font = new System.Drawing.Font("Noto Sans", 18F);
            this.twoLine.ForeColor = System.Drawing.Color.White;
            this.twoLine.Location = new System.Drawing.Point(192, 211);
            this.twoLine.Name = "twoLine";
            this.twoLine.Size = new System.Drawing.Size(312, 50);
            this.twoLine.TabIndex = 10;
            this.twoLine.Text = "-drop in the FINAL panels";
            this.twoLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // threeLine
            // 
            this.threeLine.BackColor = System.Drawing.Color.Teal;
            this.threeLine.Cursor = System.Windows.Forms.Cursors.Cross;
            this.threeLine.Font = new System.Drawing.Font("Noto Sans", 18F);
            this.threeLine.ForeColor = System.Drawing.Color.White;
            this.threeLine.Location = new System.Drawing.Point(275, 274);
            this.threeLine.Name = "threeLine";
            this.threeLine.Size = new System.Drawing.Size(150, 50);
            this.threeLine.TabIndex = 11;
            this.threeLine.Text = "-be careful";
            this.threeLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fourLine
            // 
            this.fourLine.BackColor = System.Drawing.Color.Teal;
            this.fourLine.Cursor = System.Windows.Forms.Cursors.Cross;
            this.fourLine.Font = new System.Drawing.Font("Noto Sans", 18F);
            this.fourLine.ForeColor = System.Drawing.Color.White;
            this.fourLine.Location = new System.Drawing.Point(302, 329);
            this.fourLine.Name = "fourLine";
            this.fourLine.Size = new System.Drawing.Size(95, 50);
            this.fourLine.TabIndex = 12;
            this.fourLine.Text = "-enjoy";
            this.fourLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.X);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 385);
            this.panel1.TabIndex = 13;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(724, 406);
            this.Controls.Add(this.fourLine);
            this.Controls.Add(this.threeLine);
            this.Controls.Add(this.twoLine);
            this.Controls.Add(this.oneLine);
            this.Controls.Add(this.barStat);
            this.Controls.Add(this.infoTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "info";
            this.Load += new System.EventHandler(this.info_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoTitle;
        private System.Windows.Forms.Label barStat;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label oneLine;
        private System.Windows.Forms.Label twoLine;
        private System.Windows.Forms.Label threeLine;
        private System.Windows.Forms.Label fourLine;
        private System.Windows.Forms.Panel panel1;
    }
}