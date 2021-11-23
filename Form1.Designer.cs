namespace LoginUI
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
            Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
            Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
            Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
            Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LightBlue;
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(386, 712);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.bunifuCheckbox1);
            this.pnlRight.Controls.Add(this.bunifuFlatButton1);
            this.pnlRight.Controls.Add(bunifuMaterialTextbox4);
            this.pnlRight.Controls.Add(this.label5);
            this.pnlRight.Controls.Add(bunifuMaterialTextbox3);
            this.pnlRight.Controls.Add(this.label4);
            this.pnlRight.Controls.Add(bunifuMaterialTextbox2);
            this.pnlRight.Controls.Add(this.label6);
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Controls.Add(bunifuMaterialTextbox1);
            this.pnlRight.Controls.Add(this.label2);
            this.pnlRight.Controls.Add(this.label7);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(386, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(404, 712);
            this.pnlRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // bunifuMaterialTextbox1
            // 
            bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            bunifuMaterialTextbox1.HintText = "";
            bunifuMaterialTextbox1.isPassword = false;
            bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox1.LineThickness = 3;
            bunifuMaterialTextbox1.Location = new System.Drawing.Point(34, 172);
            bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            bunifuMaterialTextbox1.Size = new System.Drawing.Size(357, 44);
            bunifuMaterialTextbox1.TabIndex = 2;
            bunifuMaterialTextbox1.Text = "Full Name";
            bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox2
            // 
            bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            bunifuMaterialTextbox2.HintText = "";
            bunifuMaterialTextbox2.isPassword = true;
            bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox2.LineThickness = 3;
            bunifuMaterialTextbox2.Location = new System.Drawing.Point(34, 358);
            bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            bunifuMaterialTextbox2.Size = new System.Drawing.Size(357, 44);
            bunifuMaterialTextbox2.TabIndex = 4;
            bunifuMaterialTextbox2.Text = "Full Name";
            bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // bunifuMaterialTextbox3
            // 
            bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            bunifuMaterialTextbox3.HintText = "";
            bunifuMaterialTextbox3.isPassword = false;
            bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox3.LineThickness = 3;
            bunifuMaterialTextbox3.Location = new System.Drawing.Point(34, 263);
            bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            bunifuMaterialTextbox3.Size = new System.Drawing.Size(357, 44);
            bunifuMaterialTextbox3.TabIndex = 6;
            bunifuMaterialTextbox3.Text = "Email@Domain.com";
            bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // bunifuMaterialTextbox4
            // 
            bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            bunifuMaterialTextbox4.HintText = "";
            bunifuMaterialTextbox4.isPassword = true;
            bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.DarkBlue;
            bunifuMaterialTextbox4.LineThickness = 3;
            bunifuMaterialTextbox4.Location = new System.Drawing.Point(34, 472);
            bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            bunifuMaterialTextbox4.Size = new System.Drawing.Size(357, 44);
            bunifuMaterialTextbox4.TabIndex = 8;
            bunifuMaterialTextbox4.Text = "Full Name";
            bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Confirm Password";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Sign Up";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(34, 593);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(357, 62);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Sign Up";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(34, 547);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "I Agree Terms and Conditions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 58);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlLeft;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 712);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRight;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

