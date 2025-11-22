using ArticleManagement.API.DTOs;
using ArticleManagementAPI.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArticleManagementAPI.Middleware
{
	public class ErrorHandlingMiddleware : IMiddleware
	{
		private readonly IAppLogger _logger;

		public ErrorHandlingMiddleware(IAppLogger logger)
		{
			_logger = logger;
		}

		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			try
			{
				await next.Invoke(context);
			}
			catch (DbUpdateException ex)
			{
				await WriteErrorResponse(ex, context, StatusCodes.Status500InternalServerError, "Database error occurred");
			}
			catch (Exception ex)
			{
				await WriteErrorResponse(ex, context, StatusCodes.Status500InternalServerError, "Internal server error");
			}
		}

		private async Task WriteErrorResponse(Exception ex, HttpContext context, int statusCode, string message)
		{
			_logger.Error(ex);

			context.Response.StatusCode = statusCode;

			var apiErrorDto = new ApiErrorDto
			{
				Error = statusCode.ToString(),
				Message = message
			};

			await context.Response.WriteAsJsonAsync(apiErrorDto);
		}
	}
}
