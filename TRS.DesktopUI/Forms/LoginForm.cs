using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRS.DesktopUI.Code;
using TRS.Entities;
using TRS.Repositories;
using TRS.Repositories.Abstract;

namespace TRS.DesktopUI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["TRS_DBConnectionString"].ConnectionString);

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            string passwordHash = AuthentificationManager.GetPasswordHash(password);
            User user = _userRepository.GetUserByLogin(login, passwordHash);

            if (user == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CurrentUser.Initialize(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
