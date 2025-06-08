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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CarregarTransacoesListView();
        }

        private void CarregarTransacoesListView()
        {
            lv_show_transacao.Items.Clear();

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                var cmd = new NpgsqlCommand(@"
            SELECT 
                u.nome AS nome_usuario,
                t.tipo_transacao,
                t.valor,
                t.descricao,
                t.data_transacao,
                c.nome_categoria,
                c.tipo_categoria
            FROM transacao t
            JOIN conta co ON t.id_conta = co.id_conta
            JOIN usuario u ON co.id_usuario = u.id_usuario
            JOIN categoria c ON t.id_categoria = c.id_categoria", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Nome do usuário é agora a primeira coluna
                        var item = new ListViewItem(reader["nome_usuario"].ToString());
                        item.SubItems.Add(reader["tipo_transacao"].ToString());
                        item.SubItems.Add(reader["valor"].ToString());
                        item.SubItems.Add(reader["descricao"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["data_transacao"]).ToShortDateString());
                        item.SubItems.Add(reader["nome_categoria"].ToString());
                        item.SubItems.Add(reader["tipo_categoria"].ToString());

                        lv_show_transacao.Items.Add(item);
                    }
                }
            }
        }

        private void exitbtn_transacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_enviartransacao_Click(object sender, EventArgs e)
        {
            try
            {
                var tipoTransacao = txt_tipo_transacao.Text;
                var valorTransacao = txt_valor_transacao.Text;
                var descricaoTransacao = txt_descricao_transacao.Text;
                var dataTransacao = txt_data_transacao.Text;
                var nomeCategoria = txt_nome_categoria.Text;
                var tipoCategoria = txt_tipo_categoria.Text;
                var nome = txt_nome_usuario.Text;

                // Validação
                if (string.IsNullOrWhiteSpace(tipoTransacao)) throw new Exception("TipoTransação é obrigatório");
                if (string.IsNullOrWhiteSpace(valorTransacao)) throw new Exception("ValorTransação é obrigatório");
                if (string.IsNullOrWhiteSpace(descricaoTransacao)) throw new Exception("DescriçãoTransação é obrigatória");
                if (string.IsNullOrWhiteSpace(dataTransacao)) throw new Exception("DataTransação é obrigatória");
                if (string.IsNullOrWhiteSpace(nomeCategoria)) throw new Exception("NomeCategoria é obrigatória");
                if (string.IsNullOrWhiteSpace(tipoCategoria)) throw new Exception("TipoCategoria é obrigatória");
                if (string.IsNullOrEmpty(nome)) throw new Exception("Nome é obrigatório");

                string connStr = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

                using (var conn = new NpgsqlConnection(connStr))
                {
                    conn.Open();

                    // Verifica se categoria já existe
                    var cmdCheckCategoria = new NpgsqlCommand("SELECT id_categoria FROM categoria WHERE nome_categoria = @nome AND tipo_categoria = @tipo", conn);
                    cmdCheckCategoria.Parameters.AddWithValue("nome", nomeCategoria);
                    cmdCheckCategoria.Parameters.AddWithValue("tipo", tipoCategoria);

                    object result = cmdCheckCategoria.ExecuteScalar();
                    int idCategoria;

                    if (result != null)
                    {
                        idCategoria = (int)result;
                    }
                    else
                    {
                        // Inserir nova categoria
                        var cmdInsertCategoria = new NpgsqlCommand("INSERT INTO categoria (nome_categoria, tipo_categoria) VALUES (@nome, @tipo) RETURNING id_categoria", conn);
                        cmdInsertCategoria.Parameters.AddWithValue("nome", nomeCategoria);
                        cmdInsertCategoria.Parameters.AddWithValue("tipo", tipoCategoria);
                        idCategoria = (int)cmdInsertCategoria.ExecuteScalar();
                    }

                    // Obter id_usuario a partir do nome
                    var cmdGetUsuario = new NpgsqlCommand("SELECT id_usuario FROM usuario WHERE nome = @nome", conn);
                    cmdGetUsuario.Parameters.AddWithValue("nome", nome);
                    object resultUsuario = cmdGetUsuario.ExecuteScalar();

                    if (resultUsuario == null)
                        throw new Exception("Usuário não encontrado.");

                    int idUsuario = (int)resultUsuario;

                    // Obter id_conta associado ao id_usuario
                    var cmdGetConta = new NpgsqlCommand("SELECT id_conta FROM conta WHERE id_usuario = @id_usuario", conn);
                    cmdGetConta.Parameters.AddWithValue("id_usuario", idUsuario);
                    object resultConta = cmdGetConta.ExecuteScalar();

                    if (resultConta == null)
                        throw new Exception("Conta não encontrada para o usuário.");

                    int idConta = (int)resultConta;

                    // Inserir transação
                    var cmdInsertTransacao = new NpgsqlCommand(@"INSERT INTO transacao 
                (id_conta, tipo_transacao, valor, descricao, data_transacao, id_categoria)
                VALUES (@id_conta, @tipo, @valor, @desc, @data, @id_cat)", conn);

                    cmdInsertTransacao.Parameters.AddWithValue("id_conta", idConta);
                    cmdInsertTransacao.Parameters.AddWithValue("tipo", tipoTransacao);
                    cmdInsertTransacao.Parameters.AddWithValue("valor", decimal.Parse(valorTransacao));
                    cmdInsertTransacao.Parameters.AddWithValue("desc", descricaoTransacao);
                    cmdInsertTransacao.Parameters.AddWithValue("data", DateTime.Parse(dataTransacao));
                    cmdInsertTransacao.Parameters.AddWithValue("id_cat", idCategoria);

                    cmdInsertTransacao.ExecuteNonQuery();
                }

                MessageBox.Show("Transação salva com sucesso!");
                CarregarTransacoesListView(); // Atualiza listview
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lv_show_transacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_show_transacao.SelectedItems.Count > 0)
            {
                var item = lv_show_transacao.SelectedItems[0];
                txt_nome_usuario.Text = item.SubItems[0].Text;
                txt_tipo_transacao.Text = item.SubItems[1].Text;
                txt_valor_transacao.Text = item.SubItems[2].Text;
                txt_descricao_transacao.Text = item.SubItems[3].Text;
                txt_data_transacao.Text = item.SubItems[4].Text;
                txt_nome_categoria.Text = item.SubItems[5].Text;
                txt_tipo_categoria.Text = item.SubItems[6].Text;
            }
        }
    }
}
