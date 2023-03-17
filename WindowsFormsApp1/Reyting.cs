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
    public partial class Reyting : Form
    {
        public Reyting()
        {
            InitializeComponent();
            LoadGridSelectReyting();
        }
        string conect = "Data Source=62.78.81.19;Initial Catalog=sigame;User ID=stud;Password=123456789";

        private void Reyting_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadGridSelectReyting()
        {
            try
            {
                string sqlText = "select *from Uchastniki order by balli desc ";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, conect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "Код";
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].HeaderText = "Имя пользователя";
                dataGridView1.Columns[1].Width = 220;
                dataGridView1.Columns[2].HeaderText = "Баллы";
                dataGridView1.Columns[2].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex, "Препдупреждения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reyting_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlText = "select *from Uchastniki order by ima ";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, conect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "Код";
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].HeaderText = "Имя пользователя";
                dataGridView1.Columns[1].Width = 220;
                dataGridView1.Columns[2].HeaderText = "Баллы";
                dataGridView1.Columns[2].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex, "Препдупреждения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlText = "select *from Uchastniki order by balli desc ";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, conect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "Код";
                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].HeaderText = "Имя пользователя";
                dataGridView1.Columns[1].Width = 220;
                dataGridView1.Columns[2].HeaderText = "Баллы";
                dataGridView1.Columns[2].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex, "Препдупреждения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlText = "select ima, sum(balli) from Uchastniki group by ima ";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlText, conect);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns[0].HeaderText = "Имя пользователя";
                dataGridView1.Columns[0].Width = 220;
                dataGridView1.Columns[1].HeaderText = "Баллы";
                dataGridView1.Columns[1].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблема с БД!" + ex, "Препдупреждения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
