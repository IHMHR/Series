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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.vwSitesAcessadosTableAdapter.Fill(this.dSviewSeries.vwSitesAcessados);
            this.vwSeriadosTableAdapter.Fill(this.dSviewSeries.vwSeriados);

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 285;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 55;

            //dataGridView2.Columns
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[1].Width = 75;
            dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[5].Width = 60;
            dataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[6].Width = 60;
            dataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[7].Width = 60;

            dataGridView2.Columns[10].Width = 350;
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    linkCell.Value = row.Cells[10].Value;
                    row.Cells[10] = linkCell;

                    string Capitalize = row.Cells[8].Value.ToString().Trim().Substring(0, 1).ToUpper();
                    Capitalize += row.Cells[8].Value.ToString().Trim().Substring(1);
                    //row.Cells[8].Value = Capitalize;
                    //dataGridView2.Rows[1].Cells[8].Value = Capitalize;
                    //dataGridView2.Rows[8].Cells[8].Value = Capitalize;
                    /*dataGridView2.CurrentRow.Cells[8].Value = Capitalize;
                    dataGridView2.EndEdit();
                    dataGridView2.CurrentRow.Cells[8].Value = Capitalize;
                    dataGridView2.EndEdit();*/
                    int i = 0;
                    dataGridView2.Rows[i].Cells[8].Value = Capitalize;
                    i++;

                }
            }
            catch(Exception error)
            {
                error.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(10))
            {
                System.Diagnostics.Process.Start(dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString());
            }
        }
    }
}
