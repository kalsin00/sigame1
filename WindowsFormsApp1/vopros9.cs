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
    public partial class vopros9 : Form
    {
        public vopros9()
        {
            InitializeComponent();
        }
        string conect = "Data Source=62.78.81.19;Initial Catalog=sigame;User ID=stud;Password=123456789";
        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            gamer frm = (gamer)this.Owner;
            if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked )
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
    }
}
