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

namespace WinFormsAulaOito
{
    public partial class Form2 : Form
    {
        private string connString = "Host=localhost;Username=postgres;Password=PostgreSQL123;Database=postgres";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome."); return;
            }
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string insertSql = "INSERT INTO usuarios (nome) VALUES (@nome)";
                using (var cmd = new NpgsqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Nome salvo com sucesso!");
            txtNome.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT nome FROM usuarios";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
    }
}
