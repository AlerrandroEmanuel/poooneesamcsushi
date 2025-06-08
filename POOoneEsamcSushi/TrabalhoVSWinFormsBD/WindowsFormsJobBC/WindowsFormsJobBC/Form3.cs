using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsJobBC
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarUsuariosEContas();
        }

        private void CarregarUsuariosEContas()
        {
            lv_show_conta.Items.Clear();

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = @"
            SELECT u.nome, c.tipo_conta, c.instituicao, c.saldo
            FROM usuario u
            JOIN conta c ON u.id_usuario = c.id_usuario";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["nome"].ToString());
                        item.SubItems.Add(reader["tipo_conta"].ToString());
                        item.SubItems.Add(reader["instituicao"].ToString());
                        item.SubItems.Add(reader["saldo"].ToString());
                        lv_show_conta.Items.Add(item);
                    }
                }

                conn.Close();
            }
        }

        private void exitbtn_conta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_show_conta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_show_conta.SelectedItems.Count > 0)
            {
                var item = lv_show_conta.SelectedItems[0];
                string nome = item.SubItems[0].Text;
                string tipoConta = item.SubItems[1].Text;
                string instituicao = item.SubItems[2].Text;
                string saldo = item.SubItems[3].Text;

                // Exemplo: preencher campos ou exibir em MessageBox
                MessageBox.Show($"Usuário: {nome}\nConta: {tipoConta}\nInstituição: {instituicao}\nSaldo: {saldo}");
            }
        }
    }
}
