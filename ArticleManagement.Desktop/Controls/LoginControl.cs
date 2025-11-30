using ArticleManagement.Desktop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleManagement.Desktop.Controls
{
	public partial class LoginControl : UserControl
	{
		private readonly IAuthService _authService;

		public event Action RegisterClicked;

		public LoginControl(IAuthService authService)
		{
			InitializeComponent();
			_authService = authService;
		}

		private async void loginButton_Click(object sender, EventArgs e)
		{
			string email = emailTextBox.Text.Trim();
			string password = passwordTextBox.Text.Trim();

			errorLabel.Text = string.Empty;

			if (string.IsNullOrEmpty(email))
			{
				emailTextBox.Focus();
				errorLabel.Text = "You must enter an e-mail";
				return;
			}
			if (string.IsNullOrEmpty(password))
			{
				passwordTextBox.Focus();
				errorLabel.Text = "You must enter a password";
				return;
			}

			loginButton.Enabled = false;
			Cursor = Cursors.WaitCursor;

			var result = await _authService.LoginAsync(email, password);

			if (result.IsSuccess)
			{
				var form = FindForm();
				if (form != null)
				{
					form.DialogResult = DialogResult.OK;
					form.Close();
				}
			}
			else
			{
				errorLabel.Text = result.ErrorMessage;
			}

			Cursor = Cursors.Default;
			loginButton.Enabled = true;
		}

		private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegisterClicked.Invoke();
		}
	}
}
