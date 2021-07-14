using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_LoginRegister_Design
{
    public partial class LoginAndRegisterForm : Form
    {
        public LoginAndRegisterForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_GoToLogin.PerformClick();
        }

        Color select_color = Color.FromArgb(49, 46, 46);

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            panel_login_bar.BackColor = Color.Yellow;
            panel_register_bar.BackColor = select_color;
            button_GoToLogin.BackColor = select_color;
            button_GoToRegister.BackColor = Color.Black;
        }

        private void button_GoToRegister_Click(object sender, EventArgs e)
        {
            panel_register.BringToFront();
            panel_register_bar.BackColor = Color.Yellow;
            panel_login_bar.BackColor = select_color;
            button_GoToRegister.BackColor = select_color;
            button_GoToLogin.BackColor = Color.Black;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
