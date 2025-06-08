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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CarregarUsuariosECategorias();
        }

        private void CarregarUsuariosECategorias()
        {
            lv_show_categoria.Items.Clear();

            string connStr = "Host=localhost;Port=5432;Username=postgres;Password=PostgreSQL123;Database=postgres";

            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                // Consulta simples: combina todos usuários com todas categorias
                // (pois não há ligação direta entre as tabelas)
                string query = @"
            SELECT u.nome AS nome_usuario, c.nome_categoria, c.tipo_categoria
            FROM usuario u
            CROSS JOIN categoria c"; // Junta todos usuários com todas categorias (ou você pode ajustar conforme sua lógica)

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["nome_usuario"].ToString());
                        item.SubItems.Add(reader["nome_categoria"].ToString());
                        item.SubItems.Add(reader["tipo_categoria"].ToString());

                        lv_show_categoria.Items.Add(item);
                    }
                }

                conn.Close();
            }
        }

        private void exitbtn_categoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_show_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_show_categoria.SelectedItems.Count > 0)
            {
                var item = lv_show_categoria.SelectedItems[0];

                string nomeUsuario = item.SubItems[0].Text;
                string nomeCategoria = item.SubItems[1].Text;
                string tipoCategoria = item.SubItems[2].Text;

                MessageBox.Show($"Usuário: {nomeUsuario}\nCategoria: {nomeCategoria}\nTipo: {tipoCategoria}");
            }
        }
    }
}
