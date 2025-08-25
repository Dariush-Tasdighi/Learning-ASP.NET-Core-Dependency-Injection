using Infrastructure.Learn05;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn05Model : PageModel
{
	public Learn05Model(Interface1 interface1) : base()
	{
		Interface1 = interface1;
	}

	public Interface1 Interface1 { get; init; }

	public void OnGet()
	{
	}
}
