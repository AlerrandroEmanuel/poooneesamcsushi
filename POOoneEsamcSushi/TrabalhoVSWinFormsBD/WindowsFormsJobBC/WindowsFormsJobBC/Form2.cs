using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsJobBC
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarDadosListView();
        }

        private void CarregarDadosListView()
        {
            lv_show_usuario.Items.Clear();

            string connString = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
            SELECT u.nome, u.email, c.tipo_conta, c.instituicao, c.saldo, 
                   m.descricao_meta, m.valor_meta, m.data_limite
            FROM usuario u
            JOIN conta c ON u.id_usuario = c.id_usuario
            JOIN metafinanceira m ON u.id_usuario = m.id_usuario", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["nome"].ToString());
                        item.SubItems.Add(reader["email"].ToString());
                        item.SubItems.Add(reader["tipo_conta"].ToString());
                        item.SubItems.Add(reader["instituicao"].ToString());
                        item.SubItems.Add(reader["saldo"].ToString());
                        item.SubItems.Add(reader["descricao_meta"].ToString());
                        item.SubItems.Add(reader["valor_meta"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["data_limite"]).ToShortDateString());
                        lv_show_usuario.Items.Add(item);
                    }
                }

                conn.Close();
            }
        }


        private void homelabelnamebusiness_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome_usuario.Text;
                var email = txt_email_usuario.Text;
                var tipoConta = txt_tipo_conta.Text;
                var instituicaoConta = txt_instituicao_conta.Text;
                var saldoConta = txt_saldo_conta.Text;
                var descricaoMeta = txt_descricao_meta_financeira.Text;
                var valorMeta = txt_valor_meta_financeira.Text;
                var dataLimiteMeta = txt_data_limite_meta_financeira.Text;

                if (string.IsNullOrEmpty(nome)) throw new Exception("Nome é obrigatório");
                if (string.IsNullOrEmpty(email)) throw new Exception("Email é obrigatório");
                if (string.IsNullOrEmpty(tipoConta)) throw new Exception("TipoConta é obrigatório");
                if (string.IsNullOrEmpty(instituicaoConta)) throw new Exception("Instituição é obrigatório");
                if (string.IsNullOrEmpty(saldoConta)) throw new Exception("Saldo é obrigatório");
                if (string.IsNullOrEmpty(descricaoMeta)) throw new Exception("DescriçãoMeta é obrigatório");
                if (string.IsNullOrEmpty(valorMeta)) throw new Exception("ValorMeta é obrigatório");
                if (string.IsNullOrEmpty(dataLimiteMeta)) throw new Exception("DataLimiteMeta é obrigatório");

                string connString = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Inserir na tabela usuario
                    var cmdUsuario = new NpgsqlCommand("INSERT INTO usuario (nome, email, data_cadastro) VALUES (@nome, @email, current_date) RETURNING id_usuario", conn);
                    cmdUsuario.Parameters.AddWithValue("nome", nome);
                    cmdUsuario.Parameters.AddWithValue("email", email);
                    var idUsuario = (int)cmdUsuario.ExecuteScalar();

                    // Inserir na tabela conta
                    var cmdConta = new NpgsqlCommand("INSERT INTO conta (id_usuario, tipo_conta, instituicao, saldo, data_abertura) VALUES (@id_usuario, @tipo, @instituicao, @saldo, current_date)", conn);
                    cmdConta.Parameters.AddWithValue("id_usuario", idUsuario);
                    cmdConta.Parameters.AddWithValue("tipo", tipoConta);
                    cmdConta.Parameters.AddWithValue("instituicao", instituicaoConta);
                    cmdConta.Parameters.AddWithValue("saldo", decimal.Parse(saldoConta));
                    cmdConta.ExecuteNonQuery();

                    // Inserir na tabela metafinanceira
                    var cmdMeta = new NpgsqlCommand("INSERT INTO metafinanceira (id_usuario, descricao_meta, valor_meta, data_limite, id_categoria) VALUES (@id_usuario, @descricao, @valor, @data_limite, 1)", conn);
                    cmdMeta.Parameters.AddWithValue("id_usuario", idUsuario);
                    cmdMeta.Parameters.AddWithValue("descricao", descricaoMeta);
                    cmdMeta.Parameters.AddWithValue("valor", decimal.Parse(valorMeta));
                    cmdMeta.Parameters.AddWithValue("data_limite", DateTime.Parse(dataLimiteMeta));
                    cmdMeta.ExecuteNonQuery();

                    conn.Close();
                }

                MessageBox.Show("Dados inseridos com sucesso!");
                CarregarDadosListView(); // Atualiza a ListView com dados do banco
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void exitbtnuser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_show_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_show_usuario.SelectedItems.Count > 0)
            {
                var item = lv_show_usuario.SelectedItems[0];
                txt_nome_usuario.Text = item.SubItems[0].Text;
                txt_email_usuario.Text = item.SubItems[1].Text;
                txt_tipo_conta.Text = item.SubItems[2].Text;
                txt_instituicao_conta.Text = item.SubItems[3].Text;
                txt_saldo_conta.Text = item.SubItems[4].Text;
                txt_descricao_meta_financeira.Text = item.SubItems[5].Text;
                txt_valor_meta_financeira.Text = item.SubItems[6].Text;
                txt_data_limite_meta_financeira.Text = item.SubItems[7].Text;
            }
        }


    }

}
