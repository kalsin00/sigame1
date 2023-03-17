using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gamer : Form
    {
        public gamer()
        {
            InitializeComponent();
            
        }
        



        private void gamer_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            vopros1 frm = new vopros1();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
            (sender as Button).Enabled = false;
            
            button1.ForeColor = Color.White;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vopros2 frm = new vopros2();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
            (sender as Button).Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros3 frm = new vopros3();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros4 frm = new vopros4();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros_5 frm = new vopros_5();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros6 frm = new vopros6();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros7 frm = new vopros7();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros8 frm = new vopros8();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            vopros9 frm = new vopros9();
            frm.Owner = this; //Передаём вновь созданной форме её владельца.
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Сюда нажимать нельзя",
        "Сообщение",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Сюда нажимать нельзя",
        "Сообщение",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Сюда нажимать нельзя",
        "Сообщение",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button1_Leave(object sender, EventArgs e)
        {

        }

        private void tbima_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
