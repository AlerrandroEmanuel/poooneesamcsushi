namespace WindowsFormsJobBC
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            exitbtn_categoria = new Button();
            lv_show_categoria = new ListView();
            Nome = new ColumnHeader();
            Tipo_Categoria = new ColumnHeader();
            Nome_Categoria = new ColumnHeader();
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
            panel1.Controls.Add(exitbtn_categoria);
            panel1.Controls.Add(lv_show_categoria);
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
            // exitbtn_categoria
            // 
            exitbtn_categoria.FlatAppearance.BorderColor = Color.Black;
            exitbtn_categoria.FlatAppearance.BorderSize = 0;
            exitbtn_categoria.FlatAppearance.MouseDownBackColor = Color.Black;
            exitbtn_categoria.FlatAppearance.MouseOverBackColor = Color.Black;
            exitbtn_categoria.FlatStyle = FlatStyle.Flat;
            exitbtn_categoria.Image = (Image)resources.GetObject("exitbtn_categoria.Image");
            exitbtn_categoria.Location = new Point(523, 138);
            exitbtn_categoria.Name = "exitbtn_categoria";
            exitbtn_categoria.RightToLeft = RightToLeft.No;
            exitbtn_categoria.Size = new Size(45, 48);
            exitbtn_categoria.TabIndex = 23;
            exitbtn_categoria.UseVisualStyleBackColor = true;
            exitbtn_categoria.Click += exitbtn_categoria_Click;
            // 
            // lv_show_categoria
            // 
            lv_show_categoria.Columns.AddRange(new ColumnHeader[] { Nome, Tipo_Categoria, Nome_Categoria });
            lv_show_categoria.Location = new Point(27, 196);
            lv_show_categoria.Name = "lv_show_categoria";
            lv_show_categoria.Size = new Size(541, 575);
            lv_show_categoria.TabIndex = 21;
            lv_show_categoria.UseCompatibleStateImageBehavior = false;
            lv_show_categoria.View = View.Details;
            lv_show_categoria.SelectedIndexChanged += lv_show_categoria_SelectedIndexChanged;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Tipo_Categoria
            // 
            Tipo_Categoria.Text = "Tipo_Categoria";
            Tipo_Categoria.Width = 120;
            // 
            // Nome_Categoria
            // 
            Nome_Categoria.Text = "Nome_Categoria";
            Nome_Categoria.Width = 120;
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
            label3.Size = new Size(173, 28);
            label3.TabIndex = 19;
            label3.Text = "Categoria";
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
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 800);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homelogocalculator).EndInit();
            ((System.ComponentModel.ISupportInitialize)homelogobee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exitbtn_categoria;
        private ListView lv_show_categoria;
        private Label label4;
        private Label label3;
        private PictureBox homelogocalculator;
        private PictureBox homelogobee;
        private Label homelabelnamebusiness;
        private ColumnHeader Nome_Categoria;
        private ColumnHeader Tipo_Categoria;
        private ColumnHeader Nome;
    }
}