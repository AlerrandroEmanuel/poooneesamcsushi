namespace WindowsFormsJobBC
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            exitbuttonhome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(634, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(653, 486);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // exitbuttonhome
            // 
            exitbuttonhome.FlatAppearance.BorderColor = Color.Black;
            exitbuttonhome.FlatAppearance.BorderSize = 0;
            exitbuttonhome.FlatAppearance.MouseDownBackColor = Color.Red;
            exitbuttonhome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitbuttonhome.FlatStyle = FlatStyle.Flat;
            exitbuttonhome.Image = (Image)resources.GetObject("exitbuttonhome.Image");
            exitbuttonhome.Location = new Point(1229, 481);
            exitbuttonhome.Name = "exitbuttonhome";
            exitbuttonhome.RightToLeft = RightToLeft.No;
            exitbuttonhome.Size = new Size(43, 41);
            exitbuttonhome.TabIndex = 10;
            exitbuttonhome.UseVisualStyleBackColor = true;
            exitbuttonhome.Click += exitbuttonhome_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 532);
            Controls.Add(exitbuttonhome);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button exitbuttonhome;
    }
}