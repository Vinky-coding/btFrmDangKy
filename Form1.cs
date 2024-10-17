using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDangKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label mylab = new Label();
            mylab.Text = "ĐĂNG KÝ";
            mylab.Size = new Size(120, 25);

            this.Controls.Add(mylab);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool IsValidEmail(string email)
        {
            bool Result = false;
            try
            {
                var eMailValid = new System.Net.Mail.MailAddress(email);
                Result = (email.LastIndexOf(".com") > email.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            }
            return false;
        }
        private bool IsValidPass(string pass) 
        { 
            string PwPattern = @"^(?=.*[!?/@&]).{8,}$";
            return Regex.IsMatch(pass, PwPattern);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if(IsValidEmail(email))
            {
                MessageBox.Show("Email khong hop le!");
                return;
            }
            if(!IsValidPass(password))
            {
                MessageBox.Show("Mat khau phai co it nhat 8 ki tu va co 1 ky tu dac biet(!,*,%,..)!");
                return;
            }

            MessageBox.Show("Dang ky thanh cong !");

        }
    }
}
