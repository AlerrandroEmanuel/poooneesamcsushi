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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CarregarMetasFinanceiras();
        }

        private void CarregarMetasFinanceiras()
        {
            lv_show_meta_financeira.Items.Clear();

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string query = @"
            SELECT u.nome, m.descricao_meta, m.valor_meta, m.data_limite
            FROM usuario u
            JOIN metafinanceira m ON u.id_usuario = m.id_usuario";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["nome"].ToString());
                        item.SubItems.Add(reader["descricao_meta"].ToString());
                        item.SubItems.Add(reader["valor_meta"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["data_limite"]).ToShortDateString());

                        lv_show_meta_financeira.Items.Add(item);
                    }
                }
            }
        }

        private void exitbtn_meta_financeira_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_show_meta_financeira_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_show_meta_financeira.SelectedItems.Count > 0)
            {
                var item = lv_show_meta_financeira.SelectedItems[0];
                string nome = item.SubItems[0].Text;
                string descricao = item.SubItems[1].Text;
                string valor = item.SubItems[2].Text;
                string data = item.SubItems[3].Text;

                MessageBox.Show($"Usuário: {nome}\nMeta: {descricao}\nValor: {valor}\nData limite: {data}");
            }
        }
    }
}
