using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_3_algoritmization
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> tl = new System.Collections.Generic.Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                label4.Visible = false;
                if (domainUpDown1.Text != "Выбор страны")
                {
                    label6.Visible = false;
                    if (textBox1.Text != "")
                    {
                        tl.Add(Convert.ToInt16(numericUpDown1.Value), textBox1.Text);
                        dataGridView1.Rows.Add(domainUpDown1.Text, textBox1.Text, numericUpDown1.Value);

                        label5.Visible = false;
                    }
                    else
                    {
                        label5.Visible = true;
                    }
                }
                else 
                {
                    label6.Visible = true;
                }
                
            }
            catch
            {
                label4.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult fr;
            fr = MessageBox.Show("Удалить самолет?","" , MessageBoxButtons.YesNo);
            if (fr == DialogResult.Yes) 
            {
                dataGridView1.Rows.RemoveAt(selectedRow);
            }
            tl.Remove(selectedRow);
        }
    }
}
