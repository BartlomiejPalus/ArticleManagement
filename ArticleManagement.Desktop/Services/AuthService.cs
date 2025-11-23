using ArticleManagement.Desktop.Common;
using ArticleManagement.Desktop.DTOs;
using ArticleManagement.Desktop.DTOs.Auth;
using ArticleManagement.Desktop.Services.Interfaces;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArticleManagement.Desktop.Services
{
	public class AuthService : IAuthService
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly IUserSession _userSession;

		public AuthService(IHttpClientFactory httpClientFactory, IUserSession userSession)
		{
			_httpClientFactory = httpClientFactory;
			_userSession = userSession;
		}

		public async Task<Result> LoginAsync(string email, string password)
		{
			try
			{
				if (_userSession.IsLoggedIn)
					return Result.Failure("You are already logged in");

				var dto = new { email, password };
				var httpClient = _httpClientFactory.CreateClient();
				var response = await httpClient.PostAsJsonAsync("auth/login", dto);

				if (response.IsSuccessStatusCode)
				{
					var result = await response.Content.ReadFromJsonAsync<LoginResponseDto>();
					if (result == null)
						return Result.Failure("Unexpected server response");

					_userSession.Login(result.AccessToken, result.RefreshToken);

					return Result.Success();
				}
				else
				{
					ApiErrorDto? error = null;

					try
					{
						error = await response.Content.ReadFromJsonAsync<ApiErrorDto>();
					}
					catch (JsonException)
					{
						return Result.Failure("Invalid credentials");
					}
					
					return Result.Failure(error?.Message ?? "Invalid credentials");
				}
			}
			catch (HttpRequestException)
			{
				return Result.Failure("Cannot connect to the server");
			}
			catch (TaskCanceledException)
			{
				return Result.Failure("Server timeout");
			}
			catch (Exception)
			{
				return Result.Failure("An unexpected error occurred");
			}
		}
	}
}
