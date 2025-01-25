using Infrastructure.Learn06;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn06Model : PageModel
{
	public Learn06Model(Interface2 interface2) : base()
	{
		Interface2 = interface2;
	}

	public Interface2 Interface2 { get; init; }

	public void OnGet()
	{
	}
}
