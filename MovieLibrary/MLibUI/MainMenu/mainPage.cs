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


namespace MLibUI.MainMenu
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private AccountBusiness accountBusiness = new AccountBusiness();

        /// <summary>
        /// Current account
        /// </summary>
        public Account currentAccount { get; set; }

        /// <summary>
        /// Set the lblUsr to Account Username
        /// </summary>
        private void mainPage_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentAccount.FirstName} {currentAccount.LastName}";
        }
    }
}
