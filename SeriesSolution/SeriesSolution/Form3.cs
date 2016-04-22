using System;
using System.Windows.Forms;
using System.Drawing;

namespace SeriesSolution
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True"))
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("INSERT INTO loja (loja,telefone) VALUES (");
                sb.Append("'" + textBox1.Text + "',");
                sb.Append("'" + textBox2.Text + "'");
                sb.Append(");");

                System.Data.SqlClient.SqlCommand cm = new System.Data.SqlClient.SqlCommand(sb.ToString(), con);
                con.Open();
                cm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salvo com sucesso!");

                con.Dispose();
                cm.Dispose();

                textBox1.Clear();
                textBox2.Clear();
            }*/

            Classes.ClsLoja lj = new Classes.ClsLoja();

            lj.loja = textBox1.Text;
            lj.telefone = textBox2.Text;

            lj.InserirLoja();

            MessageBox.Show("Salvo com sucesso!");

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @".{3,35}"))
                textBox1.ForeColor = Color.Red;
            else
                textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @".{6,20}"))
                textBox2.ForeColor = Color.Red;
            else
                textBox2.ForeColor = Color.Black;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
