using ArticleManagement.Desktop.Common;

namespace ArticleManagement.Desktop.Services.Interfaces
{
	public interface IUserService
	{
		Task<Result> RegisterAsync(string name, string email, string password);
	}
}