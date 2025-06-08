namespace WindowsFormsJobBC
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            exitbtn_conta = new Button();
            lv_show_conta = new ListView();
            Nome = new ColumnHeader();
            TipoConta = new ColumnHeader();
            Instituição = new ColumnHeader();
            Saldo = new ColumnHeader();
            label4 = new Label();
            label3 = new Label();
            homelogocalculator = new PictureBox();
            homelogobee = new PictureBox();
            homelabelnamebusiness = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homelogocalculator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homelogobee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(exitbtn_conta);
            panel1.Controls.Add(lv_show_conta);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(homelogocalculator);
            panel1.Controls.Add(homelogobee);
            panel1.Controls.Add(homelabelnamebusiness);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 800);
            panel1.TabIndex = 0;
            // 
            // exitbtn_conta
            // 
            exitbtn_conta.FlatAppearance.BorderColor = Color.Black;
            exitbtn_conta.FlatAppearance.BorderSize = 0;
            exitbtn_conta.FlatAppearance.MouseDownBackColor = Color.Black;
            exitbtn_conta.FlatAppearance.MouseOverBackColor = Color.Black;
            exitbtn_conta.FlatStyle = FlatStyle.Flat;
            exitbtn_conta.Image = (Image)resources.GetObject("exitbtn_conta.Image");
            exitbtn_conta.Location = new Point(523, 138);
            exitbtn_conta.Name = "exitbtn_conta";
            exitbtn_conta.RightToLeft = RightToLeft.No;
            exitbtn_conta.Size = new Size(45, 48);
            exitbtn_conta.TabIndex = 23;
            exitbtn_conta.UseVisualStyleBackColor = true;
            exitbtn_conta.Click += exitbtn_conta_Click;
            // 
            // lv_show_conta
            // 
            lv_show_conta.Columns.AddRange(new ColumnHeader[] { Nome, TipoConta, Instituição, Saldo });
            lv_show_conta.Location = new Point(27, 196);
            lv_show_conta.Name = "lv_show_conta";
            lv_show_conta.Size = new Size(541, 575);
            lv_show_conta.TabIndex = 21;
            lv_show_conta.UseCompatibleStateImageBehavior = false;
            lv_show_conta.View = View.Details;
            lv_show_conta.SelectedIndexChanged += lv_show_conta_SelectedIndexChanged;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // TipoConta
            // 
            TipoConta.Text = "TipoConta";
            TipoConta.Width = 120;
            // 
            // Instituição
            // 
            Instituição.Text = "Instituição";
            Instituição.Width = 120;
            // 
            // Saldo
            // 
            Saldo.Text = "Saldo";
            Saldo.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("BankGothic Md BT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(27, 145);
            label4.Name = "label4";
            label4.Size = new Size(253, 34);
            label4.TabIndex = 20;
            label4.Text = "Informações";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(181, 56);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 19;
            label3.Text = "Conta";
            // 
            // homelogocalculator
            // 
            homelogocalculator.Image = (Image)resources.GetObject("homelogocalculator.Image");
            homelogocalculator.Location = new Point(95, 41);
            homelogocalculator.Name = "homelogocalculator";
            homelogocalculator.Size = new Size(61, 59);
            homelogocalculator.SizeMode = PictureBoxSizeMode.Zoom;
            homelogocalculator.TabIndex = 18;
            homelogocalculator.TabStop = false;
            // 
            // homelogobee
            // 
            homelogobee.Image = (Image)resources.GetObject("homelogobee.Image");
            homelogobee.Location = new Point(27, 25);
            homelogobee.Name = "homelogobee";
            homelogobee.Size = new Size(62, 75);
            homelogobee.SizeMode = PictureBoxSizeMode.Zoom;
            homelogobee.TabIndex = 17;
            homelogobee.TabStop = false;
            // 
            // homelabelnamebusiness
            // 
            homelabelnamebusiness.AutoSize = true;
            homelabelnamebusiness.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homelabelnamebusiness.ForeColor = Color.Yellow;
            homelabelnamebusiness.Location = new Point(27, 103);
            homelabelnamebusiness.Name = "homelabelnamebusiness";
            homelabelnamebusiness.Size = new Size(132, 28);
            homelabelnamebusiness.TabIndex = 16;
            homelabelnamebusiness.Text = "PCbeeS";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 800);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homelogocalculator).EndInit();
            ((System.ComponentModel.ISupportInitialize)homelogobee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox homelogocalculator;
        private PictureBox homelogobee;
        private Label homelabelnamebusiness;
        private ListView lv_show_conta;
        private Label label4;
        private Button exitbtn_conta;
        private ColumnHeader Nome;
        private ColumnHeader TipoConta;
        private ColumnHeader Instituição;
        private ColumnHeader Saldo;
    }
}