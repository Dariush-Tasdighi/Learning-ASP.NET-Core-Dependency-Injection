using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn02Model : PageModel
{
	public Learn02Model() : base()
	{
		//MyClass1 =
		//	new Infrastructure.Learn02.Class1();

		MyClass1 = new();
	}

	public int MyValue { get; set; }

	public Infrastructure.Learn02.Class1 MyClass1 { get; init; }

	public void OnGet()
	{
		MyValue =
			MyClass1.MyValue;
	}
}
