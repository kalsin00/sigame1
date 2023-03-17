using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class vopros3 : Form
    {
        public vopros3()
        {
            InitializeComponent();
        }

        string conect = "Data Source=62.78.81.19;Initial Catalog=sigame;User ID=stud;Password=123456789";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            gamer frm = (gamer)this.Owner;
            if (textBox1.Text == "Сетевые" | textBox1.Text == "сетевые")
            {
                button1.BackColor = Color.Green;
                label2.Text = "Верно! Оценка: 5";

                string sqlText = "Insert into uchastniki (ima,balli) VALUES" + "('" + frm.tbima.Text.ToString() + "','" + "5')";

                using (SqlConnection con = new SqlConnection(conect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            else
            {
                button1.BackColor = Color.Red;
                label2.Text = "Ответ неверный";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
