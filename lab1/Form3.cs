using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n, m = 0;
            n = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);

            Arrays2D twodim = new Arrays2D(n, m);
            DataGridViewTextBoxColumn dvage;
            for (int i = 0; i < m; i++)
            {
                dvage = new DataGridViewTextBoxColumn();
                dvage.Width = 40;
                dataGridView1.Columns.Add(dvage);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = twodim.X_length;
            dataGridView1.ColumnCount = twodim.Y_length;
            for (int i = 0; i < twodim.X_length; i++)
                for (int j = 0; j < twodim.Y_length; j++)
                    dataGridView1.Rows[i].Cells[j].Value = twodim[i, j].ToString();
            int result = twodim.count();
            label3.Text = "Кількість " + result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();

        }
    }
}
