using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesSolution
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.situacaoTableAdapter.Fill(this.seriesDataSet2.situacao);
            if (comboBox1.Text.Equals("Em andamento"))
                dateTimePicker2.Enabled = false;
            else
                dateTimePicker2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.ForeColor.Equals(Color.Red) && textBox4.ForeColor.Equals(Color.Red))
                MessageBox.Show("Existe algum campo que não foi preenchido", "Preencher todos os campos");
            else
            {
                /*using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True"))
                {
                    try
                    {
                        if (CampoVazio())
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder("EXECUTE usp_InserirSeriado ");
                            sb.Append("'" + textBox1.Text.Trim() + "',");
                            sb.Append("'" + textBox2.Text.Replace("'","''") + "',");
                            sb.Append(textBox3.Text + ",");
                            sb.Append(textBox4.Text.Replace(",","." ) + ",");
                            string first;
                            DateTime dt = DateTime.Parse(dateTimePicker1.Text);
                            DateTime dt2 = DateTime.Parse(dateTimePicker2.Text);
                            first = dt.ToString("yyyy-MM-dd");
                            sb.Append("'" + first + "',");
                            if (!dateTimePicker2.Enabled)
                                sb.Append("NULL,");
                            else
                                 sb.Append("'" + dt2.ToString("yyyy-MM-dd") + "',");
                            sb.Append(comboBox1.SelectedValue.ToString() + ";");
                            string sql = sb.ToString();

                            System.Data.SqlClient.SqlCommand cm = new System.Data.SqlClient.SqlCommand(sql, con);
                            con.Open();
                            cm.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Salvo com sucesso!");

                            ClearFields();
                            con.Dispose();
                            cm.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }*/
                Classes.ClsSerie sr = new Classes.ClsSerie();

                sr.seriado = textBox1.Text.Trim();
                sr.descricao = textBox2.Text.Replace("'", "''");
                sr.temporadas = int.Parse(textBox3.Text);
                sr.nota = double.Parse(textBox4.Text);
                sr.dtLancamento = DateTime.Parse(dateTimePicker1.Text);
                if (dateTimePicker2.Enabled)
                    sr.dtUltimoEpisodio = DateTime.Parse(dateTimePicker2.Text);
                sr.situacaoID = (int)comboBox1.SelectedValue;

                sr.InserirSerie();

                MessageBox.Show("Salvo com sucesso!");

                ClearFields();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"[1-9]{1,3}"))
                textBox3.ForeColor = Color.Red;
            else
                textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @"[0-9]{1,2}"))
                textBox4.ForeColor = Color.Red;
            else
                textBox4.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            dateTimePicker2.Text = DateTime.Now.ToShortDateString();
        }

        private Boolean CampoVazio()
        {
            bool[] vazio = new bool[4];
            vazio[0] = textBox1.Text.Equals(string.Empty) ? true : false;
            vazio[1] = textBox2.Text.Equals(string.Empty) ? true : false;
            vazio[2] = textBox3.Text.Equals(string.Empty) ? true : false;
            vazio[3] = textBox4.Text.Equals(string.Empty) ? true : false;

            bool msg = false;
            for (int i = 0; i < vazio.Length; i++)
            {
                if (vazio[i] == true)
                    msg = true;
            }

            if (msg)
            {
                MessageBox.Show("Existe algum campo que não foi preenchido", "Preencher todos os campos");
                return false;
            }
            return true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Em andamento"))
                dateTimePicker2.Enabled = false;
            else
                dateTimePicker2.Enabled = true;
        }
    }
}
