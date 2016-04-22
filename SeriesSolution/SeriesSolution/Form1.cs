using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SeriesSolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            textBox1.MaxLength = 10;
            textBox2.MaxLength = 2;
            textBox3.MaxLength = 10;
            textBox4.MaxLength = 15;
            textBox5.MaxLength = 2;

            label8.Visible = false;

            this.lojaTableAdapter.Fill(this.seriesDataSet1.loja);
            this.seriadoTableAdapter.Fill(this.seriesDataSet.seriado);

            try
            {
                this.seriadoTableAdapter.FillBy(this.seriesDataSet.seriado);
                this.lojaTableAdapter.FillBy(this.seriesDataSet1.loja);
      
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            label8.Text = "Dias úteis";
            label8.Visible = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.ForeColor.Equals(Color.Red) && textBox2.ForeColor.Equals(Color.Red) && textBox3.ForeColor.Equals(Color.Red) && textBox4.ForeColor.Equals(Color.Red) && textBox5.ForeColor.Equals(Color.Red))
                MessageBox.Show("Existe algum campo que não foi preenchido", "Preencher todos os campos");
            else
            {
                //using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True"))
                //{
                    try
                    {
                        if (CampoVazio())
                        {
                            /*System.Text.StringBuilder sb = new System.Text.StringBuilder("EXECUTE usp_InserirVisita ");
                            DateTime dt = DateTime.Parse(dateTimePicker1.Text);
                            string t = dt.ToString("yyyy-MM-dd HH:mm:ss");
                            sb.Append("'" + t + "',");
                            sb.Append(textBox1.Text.Replace(",", ".") + ",");
                            sb.Append(textBox2.Text + ",");
                            sb.Append(textBox3.Text.Replace(",", ".") + ",");
                            sb.Append("'" + textBox4.Text + "',");
                            sb.Append(textBox5.Text + ",");
                            sb.Append("'" + textBox6.Text + "',");
                            sb.Append(comboBox2.SelectedValue.ToString() + ",");
                            sb.Append(comboBox1.SelectedValue.ToString() + ";");
                            string sql = sb.ToString();

                            System.Data.SqlClient.SqlCommand cm = new System.Data.SqlClient.SqlCommand(sql, con);
                            con.Open();
                            cm.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Salvo com sucesso!");

                            ClearFields();
                            con.Dispose();
                            cm.Dispose();*/

                            Classes.ClsAcesso ac = new Classes.ClsAcesso();

                            ac.dtAcesso = DateTime.Parse(dateTimePicker1.Text);
                            ac.LojaID = (int)comboBox2.SelectedValue;
                            ac.parcelas = int.Parse(textBox2.Text);
                            ac.SeriadoID = (int)comboBox1.SelectedValue;
                            ac.tempoFrete = int.Parse(textBox5.Text);
                            ac.tipoFrete = textBox4.Text;
                            ac.url = textBox6.Text.Trim();
                            ac.vlrFrete = double.Parse(textBox3.Text);
                            ac.vlrTotal = double.Parse(textBox1.Text);

                            ac.Inserir();

                            MessageBox.Show("Salvo com sucesso !");
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                //}
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.Value = DateTime.Now;

            label8.Visible = false;
        }

        private Boolean CampoVazio()
        {
            bool[] vazio = new bool[6];
            vazio[0] = textBox1.Text.Equals(string.Empty) ? true : false;
            vazio[1] = textBox2.Text.Equals(string.Empty) ? true : false;
            vazio[2] = textBox3.Text.Equals(string.Empty) ? true : false;
            vazio[3] = textBox4.Text.Equals(string.Empty) ? true : false;
            vazio[4] = textBox5.Text.Equals(string.Empty) ? true : false;
            vazio[5] = textBox6.Text.Equals(string.Empty) ? true : false;

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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"[0-9]*,[0-9]{2}"))
                textBox1.ForeColor = Color.Red;
            else
                textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"[1-9]{1,2}"))
                textBox2.ForeColor = Color.Red;
            else
                textBox2.ForeColor = Color.Black;  
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"[0-9]*,[0-9]{2}"))
                textBox3.ForeColor = Color.Red;
            else       
                textBox3.ForeColor = Color.Black;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, @".+[a-zA-z]+.+"))
                textBox4.ForeColor = Color.Red;
            else
                textBox4.ForeColor = Color.Black;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"[0-9]{1,2}"))
                textBox5.ForeColor = Color.Red;
            else
                textBox5.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
