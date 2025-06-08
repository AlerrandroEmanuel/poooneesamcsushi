namespace WindowsFormsJobBC
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            exitbtn_meta_financeira = new Button();
            lv_show_meta_financeira = new ListView();
            Nome = new ColumnHeader();
            Descrição = new ColumnHeader();
            Valor_Limite = new ColumnHeader();
            Data_Limite = new ColumnHeader();
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
            panel1.Controls.Add(exitbtn_meta_financeira);
            panel1.Controls.Add(lv_show_meta_financeira);
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
            panel1.TabIndex = 1;
            // 
            // exitbtn_meta_financeira
            // 
            exitbtn_meta_financeira.FlatAppearance.BorderColor = Color.Black;
            exitbtn_meta_financeira.FlatAppearance.BorderSize = 0;
            exitbtn_meta_financeira.FlatAppearance.MouseDownBackColor = Color.Black;
            exitbtn_meta_financeira.FlatAppearance.MouseOverBackColor = Color.Black;
            exitbtn_meta_financeira.FlatStyle = FlatStyle.Flat;
            exitbtn_meta_financeira.Image = (Image)resources.GetObject("exitbtn_meta_financeira.Image");
            exitbtn_meta_financeira.Location = new Point(523, 138);
            exitbtn_meta_financeira.Name = "exitbtn_meta_financeira";
            exitbtn_meta_financeira.RightToLeft = RightToLeft.No;
            exitbtn_meta_financeira.Size = new Size(45, 48);
            exitbtn_meta_financeira.TabIndex = 23;
            exitbtn_meta_financeira.UseVisualStyleBackColor = true;
            exitbtn_meta_financeira.Click += exitbtn_meta_financeira_Click;
            // 
            // lv_show_meta_financeira
            // 
            lv_show_meta_financeira.Columns.AddRange(new ColumnHeader[] { Nome, Descrição, Valor_Limite, Data_Limite });
            lv_show_meta_financeira.Location = new Point(27, 196);
            lv_show_meta_financeira.Name = "lv_show_meta_financeira";
            lv_show_meta_financeira.Size = new Size(541, 575);
            lv_show_meta_financeira.TabIndex = 21;
            lv_show_meta_financeira.UseCompatibleStateImageBehavior = false;
            lv_show_meta_financeira.View = View.Details;
            lv_show_meta_financeira.SelectedIndexChanged += lv_show_meta_financeira_SelectedIndexChanged;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Descrição
            // 
            Descrição.Text = "Descrição";
            Descrição.Width = 120;
            // 
            // Valor_Limite
            // 
            Valor_Limite.Text = "Valor_Limite";
            Valor_Limite.Width = 120;
            // 
            // Data_Limite
            // 
            Data_Limite.Text = "Data_Limite";
            Data_Limite.Width = 120;
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
            label3.Size = new Size(268, 28);
            label3.TabIndex = 19;
            label3.Text = "Meta Financeira";
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
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 800);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homelogocalculator).EndInit();
            ((System.ComponentModel.ISupportInitialize)homelogobee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exitbtn_meta_financeira;
        private ListView lv_show_meta_financeira;
        private Label label4;
        private Label label3;
        private PictureBox homelogocalculator;
        private PictureBox homelogobee;
        private Label homelabelnamebusiness;
        private ColumnHeader Nome;
        private ColumnHeader Descrição;
        private ColumnHeader Valor_Limite;
        private ColumnHeader Data_Limite;
    }
}