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
    public partial class vopros_5 : Form
    {
        public vopros_5()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        string conect = "Data Source=62.78.81.19;Initial Catalog=sigame;User ID=stud;Password=123456789";
        private void button2_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            gamer frm = (gamer)this.Owner;
            if (radioButton2.Checked)
            {
                button2.BackColor = Color.Green;
                label2.Text = "Верно! Оценка: 4";
                string sqlText = "Insert into uchastniki (ima,balli) VALUES" + "('" + frm.tbima.Text.ToString() + "','" + "4')";

                using (SqlConnection con = new SqlConnection(conect))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlText, con);
                    int kol = cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            if (radioButton1.Checked | radioButton3.Checked)
            {
                button2.BackColor = Color.Red;
                label2.Text = "Ответ неверный";
            }
        }

        private void vopros_5_Load(object sender, EventArgs e)
        {

        }
    }
}
