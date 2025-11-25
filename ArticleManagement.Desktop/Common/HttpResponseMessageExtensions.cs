using ArticleManagement.Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArticleManagement.Desktop.Common
{
	public static class HttpResponseMessageExtensions
	{
		public static async Task<string> GetApiErrorAsync(this HttpResponseMessage response)
		{
			try
			{
				var error = await response.Content.ReadFromJsonAsync<ApiErrorDto>();
				return error?.Message ?? "Request failed";
			}
			catch (JsonException)
			{
				return "Invalid server response";
			}
		}
	}
}
