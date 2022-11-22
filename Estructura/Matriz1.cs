using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura
{
    public partial class Matriz1 : Form
    {
        public Matriz1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column", "");
            dataGridView2.Columns.Add("Column", "");
            dataGridView3.Columns.Add("Column", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    if (dataGridView3.Rows.Count - 1 < dataGridView1.Rows.Count - 1)
                    {
                        dataGridView3.Rows.Add(new DataGridViewRow());
                    }

                    suma = int.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString()) + int.Parse(dataGridView2.Rows[j].Cells[i].Value.ToString());
                    dataGridView3.Rows[j].Cells[i].Value = suma;
                }
            }
        }
    }
}


