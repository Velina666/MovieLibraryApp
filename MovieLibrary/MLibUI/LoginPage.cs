using Business;
using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MLibUI.MainMenu;

namespace MLibUI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates account business
        /// </summary>
        private AccountBusiness accountBusiness = new AccountBusiness();

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxUsr_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals("Username"))
            {
                txtBoxUsr.Clear();
            }
            lblUsrException.Text = "";
            panelUsr.BackColor = Color.Goldenrod;
            txtBoxUsr.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxUsr_Leave(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals(""))
            {
                txtBoxUsr.Text = "Username";
                txtBoxUsr.ForeColor = Color.DimGray;
            }
            panelUsr.BackColor = Color.Black;
        }

        /// <summary>
        /// Clears the text box and change the ForeColor of the textBox and the color of the underline, and set systemPassChar
        /// </summary>
        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals("Password"))
            {
                txtBoxPass.Clear();
            }
            panelPass.BackColor = Color.Goldenrod;
            txtBoxPass.ForeColor = Color.Black;
            txtBoxPass.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark, and stop the SystemPassChar
        /// </summary>
        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals("") || txtBoxPass.Equals("Password"))
            {
                txtBoxPass.Text = "Password";
                txtBoxPass.ForeColor = Color.DimGray;
                txtBoxPass.UseSystemPasswordChar = false;
            }
            panelPass.BackColor = Color.Black;
        }


        /// <summary>
        /// Change eye color to Goldenrod
        /// </summary>
        private void lblEye_MouseHover(object sender, EventArgs e)
        {
            lblEye.ForeColor = Color.Goldenrod;
        }

        /// <summary>
        /// Change eye color to Black
        /// </summary>
        private void lblEye_MouseLeave(object sender, EventArgs e)
        {
            lblEye.ForeColor = Color.Black;
        }

        /// <summary>
        /// Change the SystemPassChar to oposite on txtBoxPass
        /// </summary>
        private void lblEye_Click(object sender, EventArgs e)
        {
            bool currentStatus = txtBoxPass.UseSystemPasswordChar;
            txtBoxPass.UseSystemPasswordChar = !currentStatus;
        }

        /// <summary>
        /// Close the application
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Identify the account, and login into application, throws MessageBow if the user or pass is incorrect
        /// </summary>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Account currentAcc = accountBusiness.Get(txtBoxUsr.Text.ToString());
            if (currentAcc == null || !currentAcc.Password.Equals(txtBoxPass.Text))
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
            else
            {
                mainPage mp = new mainPage();
                mp.currentAccount = currentAcc;
                mp.Show();
                this.Hide();
            }
        }

    }
}
