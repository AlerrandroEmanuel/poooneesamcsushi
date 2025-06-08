namespace WindowsFormsJobBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void homebutaotelainteira_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            homebutaominimizar.Visible = true;
        }

        private void homebutaofechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homebutaominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            homebutaominimizar.Visible = true;
        }

        private void homelabelnamebusinessfull_Click(object sender, EventArgs e)
        {

        }

        private void homelabelnamebusiness_Click(object sender, EventArgs e)
        {

        }

        private void exitbuttonhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelpageonehome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuariobuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void contabuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void transacaobuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void categoriabuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5>();
        }

        private void metafinanceirabuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form6>();
        }

        private void termoeusobuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form7>();
        }

        private void PPbuttonhome_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form8>();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }

    }
}
