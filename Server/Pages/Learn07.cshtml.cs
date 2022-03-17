namespace Server.Pages
{
	public class Learn07Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn07Model(Infrastructure.Learn07.ILog logger) : base()
		{
			Logger = logger;
		}

		public Infrastructure.Learn07.ILog Logger { get; }

		public void OnGet()
		{
			Logger.Log(message: "User came to 'Learn07'!");
		}
	}
}
