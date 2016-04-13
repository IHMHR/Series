﻿using System;
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.ForeColor.Equals(Color.Red) && textBox4.ForeColor.Equals(Color.Red))
                MessageBox.Show("Existe algum campo que não foi preenchido", "Preencher todos os campos");
            else
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=MARTINELLI-07\SQLEXPRESS;Initial Catalog=series;Integrated Security=True"))
                {
                    try
                    {
                        if (CampoVazio())
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder("EXECUTE usp_InserirSeriado ");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
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
    }
}
