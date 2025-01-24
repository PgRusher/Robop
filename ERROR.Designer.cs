namespace Roboping
{
    partial class ERROR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERROR));
            this.DONE2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CirclePictureBox7 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.errortext = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // DONE2
            // 
            this.DONE2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DONE2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.DONE2.BorderRadius = 5;
            this.DONE2.BorderThickness = 2;
            this.DONE2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DONE2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DONE2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DONE2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DONE2.FillColor = System.Drawing.Color.Transparent;
            this.DONE2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.DONE2.ForeColor = System.Drawing.Color.White;
            this.DONE2.Location = new System.Drawing.Point(166, 116);
            this.DONE2.Name = "DONE2";
            this.DONE2.Size = new System.Drawing.Size(69, 32);
            this.DONE2.TabIndex = 142;
            this.DONE2.Text = "OK";
            this.DONE2.Click += new System.EventHandler(this.DONE2_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2CirclePictureBox7
            // 
            this.guna2CirclePictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox7.Image")));
            this.guna2CirclePictureBox7.ImageRotate = 0F;
            this.guna2CirclePictureBox7.Location = new System.Drawing.Point(0, 2);
            this.guna2CirclePictureBox7.Name = "guna2CirclePictureBox7";
            this.guna2CirclePictureBox7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox7.Size = new System.Drawing.Size(35, 35);
            this.guna2CirclePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox7.TabIndex = 136;
            this.guna2CirclePictureBox7.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 50;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // errortext
            // 
            this.errortext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errortext.BackColor = System.Drawing.Color.Transparent;
            this.errortext.BorderColor = System.Drawing.Color.Transparent;
            this.errortext.BorderRadius = 10;
            this.errortext.BorderThickness = 1;
            this.errortext.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(25)))));
            this.errortext.CustomBorderColor = System.Drawing.Color.Transparent;
            this.errortext.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.errortext.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.errortext.CustomImages.ImageOffset = new System.Drawing.Point(-5, -1);
            this.errortext.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.errortext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.errortext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.errortext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.errortext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.errortext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.errortext.FocusedColor = System.Drawing.Color.White;
            this.errortext.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.errortext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.errortext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.errortext.ImageSize = new System.Drawing.Size(300, 300);
            this.errortext.Location = new System.Drawing.Point(12, 36);
            this.errortext.Name = "errortext";
            this.errortext.PressedColor = System.Drawing.Color.Transparent;
            this.errortext.Size = new System.Drawing.Size(376, 72);
            this.errortext.TabIndex = 181;
            // 
            // ERROR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.Controls.Add(this.errortext);
            this.Controls.Add(this.DONE2);
            this.Controls.Add(this.guna2CirclePictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ERROR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "error";
            this.Load += new System.EventHandler(this.ERROR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox7;
        private Guna.UI2.WinForms.Guna2Button DONE2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2Button errortext;
    }
}