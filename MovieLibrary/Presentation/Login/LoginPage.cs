using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the text box and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxUsr_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals("Username"))
            {
                txtBoxUsr.Clear();
            }
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
            lblEye.ForeColor= Color.Black;
        }
    }
}
