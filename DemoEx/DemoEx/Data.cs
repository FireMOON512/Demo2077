using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driveDataSet6.transport_view". При необходимости она может быть перемещена или удалена.
            this.transport_viewTableAdapter1.Fill(this.driveDataSet6.transport_view);
           


        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Add frm = new Add();
            frm.Show();
            this.Hide();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            Admin frm = new Admin();
            frm.Show();
            this.Hide();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            Log frm = new Log();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            transportviewBindingSource1.Filter = $"transport_number like '*{textBox1.Text}*'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    transportviewBindingSource1.Filter = $"price >= 0 and price <= 199";
                    break;


                case 1:
                    transportviewBindingSource1.Filter = $"price >= 200 and price <= 1000";
                    break;

                case 2:
                    transportviewBindingSource1.Filter = $"price > 1000";
                    break;

                


            }
        }
    }
}
