using ArticleManagement.Desktop.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleManagement.Desktop.Forms
{
	public partial class LoginForm : Form
	{
		private readonly LoginControl _loginControl;
		private readonly RegisterControl _registerControl;

		public LoginForm(LoginControl loginControl, RegisterControl registerControl)
		{
			InitializeComponent();

			_loginControl = loginControl;
			_registerControl = registerControl;

			Controls.Add(_loginControl);
			Controls.Add(_registerControl);

			_loginControl.Dock = DockStyle.Fill;
			_registerControl.Dock = DockStyle.Fill;

			SwitchToLogin();

			_loginControl.RegisterClicked += SwitchToRegister;
			_registerControl.LoginClicked += SwitchToLogin;
		}

		public void SwitchToRegister()
		{
			_loginControl.Visible = false;
			_registerControl.Visible = true;
		}

		public void SwitchToLogin()
		{
			_registerControl.Visible = false;
			_loginControl.Visible = true;
		}
	}
}
