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
	public partial class RegisterControl : UserControl
	{
		private readonly IUserService _userService;

		public event Action LoginClicked;

		public RegisterControl(IUserService userService)
		{
			InitializeComponent();
			_userService = userService;
		}

		private async void registerButton_Click(object sender, EventArgs e)
		{
			string name = nameTextBox.Text.Trim();
			string email = emailTextBox.Text.Trim();
			string password = passwordTextBox.Text.Trim();

			errorLabel.Text = string.Empty;

			if (string.IsNullOrEmpty(name))
			{
				nameTextBox.Focus();
				errorLabel.Text = "You must enter a name";
				return;
			}
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

			registerButton.Enabled = false;
			Cursor = Cursors.WaitCursor;

			var result = await _userService.RegisterAsync(name, email, password);

			if (result.IsSuccess)
			{
				LoginClicked.Invoke();
			}
			else
			{
				errorLabel.Text = result.ErrorMessage;
			}

			Cursor = Cursors.Default;
			registerButton.Enabled = true;
		}

		private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LoginClicked.Invoke();
		}
	}
}
