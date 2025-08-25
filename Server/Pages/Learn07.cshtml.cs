using Infrastructure.Learn07;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn07Model : PageModel
{
	public Learn07Model(ILogger logger) : base()
	{
		Logger = logger;
	}

	public ILogger Logger { get; init; }

	public void OnGet()
	{
		Logger.Log(message: "User came to 'Learn07'!");
	}
}
