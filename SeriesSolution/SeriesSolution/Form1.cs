using System;
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
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if(textBox1.Text.Contains(',')) 
            {
                e.Handled = true;
            }

            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar == '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (textBox1.Text.Contains(','))
            {
                e.Handled = true;
            }

            if(char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using(System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True"))
            {
                try 
	            {	        
	            	con.Open();
	            }
	            catch (Exception ex)
	            {
	            	MessageBox.Show(ex.Message.ToString());
	            }
            }
        }
    }
}
