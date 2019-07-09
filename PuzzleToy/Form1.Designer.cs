namespace PuzzleToy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showDDen = new System.Windows.Forms.Button();
            this.programmingQuote1 = new System.Windows.Forms.Label();
            this.hideShowPanel = new System.Windows.Forms.Panel();
            this.level5 = new System.Windows.Forms.Label();
            this.level4 = new System.Windows.Forms.Label();
            this.level3 = new System.Windows.Forms.Label();
            this.level2 = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleTxt = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.Button();
            this.programmingQuote2 = new System.Windows.Forms.Label();
            this.me = new System.Windows.Forms.Label();
            this.level11 = new PuzzleToy.level1();
            this.level21 = new PuzzleToy.level2();
            this.level31 = new PuzzleToy.level3();
            this.level41 = new PuzzleToy.level4();
            this.level51 = new PuzzleToy.level5();
            this.hideShowPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showDDen
            // 
            this.showDDen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.showDDen.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.showDDen.Dock = System.Windows.Forms.DockStyle.Right;
            this.showDDen.FlatAppearance.BorderSize = 0;
            this.showDDen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDDen.Font = new System.Drawing.Font("Monospac821 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDDen.ForeColor = System.Drawing.Color.White;
            this.showDDen.Location = new System.Drawing.Point(1343, 78);
            this.showDDen.Name = "showDDen";
            this.showDDen.Size = new System.Drawing.Size(62, 683);
            this.showDDen.TabIndex = 0;
            this.showDDen.Text = "H\r\n\r\n\r\nI\r\n\r\n\r\nD\r\n\r\n\r\nE";
            this.showDDen.UseVisualStyleBackColor = false;
            this.showDDen.Click += new System.EventHandler(this.showDDen_Click);
            this.showDDen.MouseHover += new System.EventHandler(this.showDDen_MouseHover);
            // 
            // programmingQuote1
            // 
            this.programmingQuote1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.programmingQuote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmingQuote1.ForeColor = System.Drawing.Color.White;
            this.programmingQuote1.Location = new System.Drawing.Point(1127, 370);
            this.programmingQuote1.Name = "programmingQuote1";
            this.programmingQuote1.Size = new System.Drawing.Size(213, 111);
            this.programmingQuote1.TabIndex = 1;
            this.programmingQuote1.Text = "while ( puzzle ) {\r\n       do your job\r\n}\r\nexit";
            this.programmingQuote1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hideShowPanel
            // 
            this.hideShowPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.hideShowPanel.Controls.Add(this.level5);
            this.hideShowPanel.Controls.Add(this.level4);
            this.hideShowPanel.Controls.Add(this.level3);
            this.hideShowPanel.Controls.Add(this.level2);
            this.hideShowPanel.Controls.Add(this.level1);
            this.hideShowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.hideShowPanel.Location = new System.Drawing.Point(1104, 78);
            this.hideShowPanel.Name = "hideShowPanel";
            this.hideShowPanel.Size = new System.Drawing.Size(239, 683);
            this.hideShowPanel.TabIndex = 2;
            // 
            // level5
            // 
            this.level5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.level5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level5.ForeColor = System.Drawing.Color.White;
            this.level5.Location = new System.Drawing.Point(45, 571);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(166, 43);
            this.level5.TabIndex = 4;
            this.level5.Text = "LEVEL 5";
            this.level5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.level5.Click += new System.EventHandler(this.level5_Click);
            this.level5.MouseHover += new System.EventHandler(this.level5_MouseHover);
            // 
            // level4
            // 
            this.level4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.level4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level4.ForeColor = System.Drawing.Color.White;
            this.level4.Location = new System.Drawing.Point(45, 470);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(166, 43);
            this.level4.TabIndex = 3;
            this.level4.Text = "LEVEL 4";
            this.level4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.level4.Click += new System.EventHandler(this.level4_Click);
            this.level4.MouseHover += new System.EventHandler(this.level4_MouseHover);
            // 
            // level3
            // 
            this.level3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.level3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3.ForeColor = System.Drawing.Color.White;
            this.level3.Location = new System.Drawing.Point(45, 366);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(166, 43);
            this.level3.TabIndex = 2;
            this.level3.Text = "LEVEL 3";
            this.level3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.level3.Click += new System.EventHandler(this.level3_Click);
            this.level3.MouseHover += new System.EventHandler(this.level3_MouseHover);
            // 
            // level2
            // 
            this.level2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.level2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2.ForeColor = System.Drawing.Color.White;
            this.level2.Location = new System.Drawing.Point(45, 261);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(166, 43);
            this.level2.TabIndex = 1;
            this.level2.Text = "LEVEL 2";
            this.level2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            this.level2.MouseHover += new System.EventHandler(this.level2_MouseHover);
            // 
            // level1
            // 
            this.level1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.level1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.ForeColor = System.Drawing.Color.White;
            this.level1.Location = new System.Drawing.Point(45, 158);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(166, 43);
            this.level1.TabIndex = 0;
            this.level1.Text = "LEVEL 1";
            this.level1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            this.level1.MouseHover += new System.EventHandler(this.level1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.LightSalmon;
            this.titlePanel.Controls.Add(this.titleTxt);
            this.titlePanel.Controls.Add(this.infoBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1405, 78);
            this.titlePanel.TabIndex = 3;
            // 
            // titleTxt
            // 
            this.titleTxt.BackColor = System.Drawing.Color.CadetBlue;
            this.titleTxt.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.titleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTxt.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.ForeColor = System.Drawing.Color.White;
            this.titleTxt.Location = new System.Drawing.Point(95, 0);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(1310, 78);
            this.titleTxt.TabIndex = 1;
            this.titleTxt.Text = "                    PuzzleToy - Nature\r\n";
            this.titleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleTxt.MouseHover += new System.EventHandler(this.titleTxt_MouseHover);
            // 
            // infoBtn
            // 
            this.infoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.infoBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoBtn.FlatAppearance.BorderSize = 0;
            this.infoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBtn.ForeColor = System.Drawing.Color.White;
            this.infoBtn.Location = new System.Drawing.Point(0, 0);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(95, 78);
            this.infoBtn.TabIndex = 0;
            this.infoBtn.Text = "I N F O";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            this.infoBtn.MouseHover += new System.EventHandler(this.infoBtn_MouseHover);
            // 
            // programmingQuote2
            // 
            this.programmingQuote2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.programmingQuote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmingQuote2.ForeColor = System.Drawing.Color.White;
            this.programmingQuote2.Location = new System.Drawing.Point(1149, 149);
            this.programmingQuote2.Name = "programmingQuote2";
            this.programmingQuote2.Size = new System.Drawing.Size(183, 111);
            this.programmingQuote2.TabIndex = 5;
            this.programmingQuote2.Text = "if ( ok ) {\r\n      continue\r\n}\r\ngo";
            this.programmingQuote2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // me
            // 
            this.me.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.me.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me.ForeColor = System.Drawing.Color.White;
            this.me.Location = new System.Drawing.Point(1150, 567);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(183, 111);
            this.me.TabIndex = 6;
            this.me.Text = "@uthor: Horja\r\n        Robert         Emanuel";
            this.me.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // level11
            // 
            this.level11.BackColor = System.Drawing.Color.Teal;
            this.level11.Location = new System.Drawing.Point(0, 78);
            this.level11.Name = "level11";
            this.level11.Size = new System.Drawing.Size(1104, 680);
            this.level11.TabIndex = 7;
            // 
            // level21
            // 
            this.level21.BackColor = System.Drawing.Color.Teal;
            this.level21.Location = new System.Drawing.Point(0, 78);
            this.level21.Name = "level21";
            this.level21.Size = new System.Drawing.Size(1104, 680);
            this.level21.TabIndex = 8;
            // 
            // level31
            // 
            this.level31.BackColor = System.Drawing.Color.Teal;
            this.level31.Location = new System.Drawing.Point(0, 78);
            this.level31.Name = "level31";
            this.level31.Size = new System.Drawing.Size(1104, 680);
            this.level31.TabIndex = 9;
            // 
            // level41
            // 
            this.level41.BackColor = System.Drawing.Color.Teal;
            this.level41.Location = new System.Drawing.Point(0, 78);
            this.level41.Name = "level41";
            this.level41.Size = new System.Drawing.Size(1104, 680);
            this.level41.TabIndex = 10;
            // 
            // level51
            // 
            this.level51.BackColor = System.Drawing.Color.Teal;
            this.level51.Location = new System.Drawing.Point(0, 78);
            this.level51.Name = "level51";
            this.level51.Size = new System.Drawing.Size(1104, 680);
            this.level51.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1405, 761);
            this.Controls.Add(this.level11);
            this.Controls.Add(this.hideShowPanel);
            this.Controls.Add(this.showDDen);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.programmingQuote1);
            this.Controls.Add(this.programmingQuote2);
            this.Controls.Add(this.me);
            this.Controls.Add(this.level21);
            this.Controls.Add(this.level31);
            this.Controls.Add(this.level41);
            this.Controls.Add(this.level51);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1421, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "||| PuzzleToy - Nature |||";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hideShowPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showDDen;
        private System.Windows.Forms.Label programmingQuote1;
        private System.Windows.Forms.Panel hideShowPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Label level5;
        private System.Windows.Forms.Label level4;
        private System.Windows.Forms.Label level3;
        private System.Windows.Forms.Label level2;
        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.Label programmingQuote2;
        private System.Windows.Forms.Label me;
        private level1 level11;
        private level2 level21;
        private level3 level31;
        private level4 level41;
        private level5 level51;
    }
}

