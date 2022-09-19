namespace KageForwarder
{
    partial class pixelworld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pixelworld));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.userkek = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cognitotext = new Client.iTalk_TextBox_Small();
            this.lastlogintext = new Client.iTalk_TextBox_Small();
            this.apply = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.userkek);
            this.bunifuPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuPanel1.Location = new System.Drawing.Point(-9, -4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(366, 40);
            this.bunifuPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(325, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userkek
            // 
            this.userkek.AutoSize = true;
            this.userkek.BackColor = System.Drawing.Color.Transparent;
            this.userkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userkek.ForeColor = System.Drawing.Color.White;
            this.userkek.Location = new System.Drawing.Point(18, 10);
            this.userkek.Name = "userkek";
            this.userkek.Size = new System.Drawing.Size(17, 22);
            this.userkek.TabIndex = 3;
            this.userkek.Text = "*";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Last login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cognito:";
            // 
            // cognitotext
            // 
            this.cognitotext.BackColor = System.Drawing.Color.Transparent;
            this.cognitotext.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cognitotext.ForeColor = System.Drawing.Color.DimGray;
            this.cognitotext.Location = new System.Drawing.Point(112, 46);
            this.cognitotext.MaxLength = 32767;
            this.cognitotext.Multiline = false;
            this.cognitotext.Name = "cognitotext";
            this.cognitotext.ReadOnly = false;
            this.cognitotext.Size = new System.Drawing.Size(224, 28);
            this.cognitotext.TabIndex = 18;
            this.cognitotext.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cognitotext.UseSystemPasswordChar = false;
            // 
            // lastlogintext
            // 
            this.lastlogintext.BackColor = System.Drawing.Color.Transparent;
            this.lastlogintext.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lastlogintext.ForeColor = System.Drawing.Color.DimGray;
            this.lastlogintext.Location = new System.Drawing.Point(112, 80);
            this.lastlogintext.MaxLength = 32767;
            this.lastlogintext.Multiline = false;
            this.lastlogintext.Name = "lastlogintext";
            this.lastlogintext.ReadOnly = false;
            this.lastlogintext.Size = new System.Drawing.Size(224, 28);
            this.lastlogintext.TabIndex = 19;
            this.lastlogintext.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastlogintext.UseSystemPasswordChar = false;
            // 
            // apply
            // 
            this.apply.AllowAnimations = true;
            this.apply.AllowMouseEffects = true;
            this.apply.AllowToggling = false;
            this.apply.AnimationSpeed = 200;
            this.apply.AutoGenerateColors = false;
            this.apply.AutoRoundBorders = true;
            this.apply.AutoSizeLeftIcon = true;
            this.apply.AutoSizeRightIcon = true;
            this.apply.BackColor = System.Drawing.Color.Transparent;
            this.apply.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apply.BackgroundImage")));
            this.apply.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply.ButtonText = "Apply";
            this.apply.ButtonTextMarginLeft = 0;
            this.apply.ColorContrastOnClick = 45;
            this.apply.ColorContrastOnHover = 45;
            this.apply.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.apply.CustomizableEdges = borderEdges1;
            this.apply.DialogResult = System.Windows.Forms.DialogResult.None;
            this.apply.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.apply.DisabledFillColor = System.Drawing.Color.Empty;
            this.apply.DisabledForecolor = System.Drawing.Color.Empty;
            this.apply.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.IconLeft = null;
            this.apply.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apply.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.apply.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.apply.IconMarginLeft = 11;
            this.apply.IconPadding = 10;
            this.apply.IconRight = null;
            this.apply.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.apply.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.apply.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.apply.IconSize = 25;
            this.apply.IdleBorderColor = System.Drawing.Color.Empty;
            this.apply.IdleBorderRadius = 0;
            this.apply.IdleBorderThickness = 0;
            this.apply.IdleFillColor = System.Drawing.Color.Empty;
            this.apply.IdleIconLeftImage = null;
            this.apply.IdleIconRightImage = null;
            this.apply.IndicateFocus = false;
            this.apply.Location = new System.Drawing.Point(186, 125);
            this.apply.Name = "apply";
            this.apply.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.apply.OnDisabledState.BorderRadius = 39;
            this.apply.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply.OnDisabledState.BorderThickness = 1;
            this.apply.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.apply.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.apply.OnDisabledState.IconLeftImage = null;
            this.apply.OnDisabledState.IconRightImage = null;
            this.apply.onHoverState.BorderColor = System.Drawing.Color.Lime;
            this.apply.onHoverState.BorderRadius = 39;
            this.apply.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply.onHoverState.BorderThickness = 1;
            this.apply.onHoverState.FillColor = System.Drawing.Color.ForestGreen;
            this.apply.onHoverState.ForeColor = System.Drawing.Color.White;
            this.apply.onHoverState.IconLeftImage = null;
            this.apply.onHoverState.IconRightImage = null;
            this.apply.OnIdleState.BorderColor = System.Drawing.Color.Lime;
            this.apply.OnIdleState.BorderRadius = 39;
            this.apply.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply.OnIdleState.BorderThickness = 1;
            this.apply.OnIdleState.FillColor = System.Drawing.Color.ForestGreen;
            this.apply.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.apply.OnIdleState.IconLeftImage = null;
            this.apply.OnIdleState.IconRightImage = null;
            this.apply.OnPressedState.BorderColor = System.Drawing.Color.Lime;
            this.apply.OnPressedState.BorderRadius = 39;
            this.apply.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.apply.OnPressedState.BorderThickness = 1;
            this.apply.OnPressedState.FillColor = System.Drawing.Color.ForestGreen;
            this.apply.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.apply.OnPressedState.IconLeftImage = null;
            this.apply.OnPressedState.IconRightImage = null;
            this.apply.Size = new System.Drawing.Size(150, 39);
            this.apply.TabIndex = 20;
            this.apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.apply.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.apply.TextMarginLeft = 0;
            this.apply.TextPadding = new System.Windows.Forms.Padding(0);
            this.apply.UseDefaultRadiusAndThickness = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // pixelworld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(348, 176);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.lastlogintext);
            this.Controls.Add(this.cognitotext);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pixelworld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pixelworld";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton apply;
        private Client.iTalk_TextBox_Small lastlogintext;
        private Client.iTalk_TextBox_Small cognitotext;
    }
}