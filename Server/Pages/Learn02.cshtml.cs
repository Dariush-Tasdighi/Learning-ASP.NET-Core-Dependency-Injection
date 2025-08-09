using Infrastructure.Learn02;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

public class Learn02Model : PageModel
{
	public Learn02Model() : base()
	{
		MyClass1 = new();
		//MyClass1 = new Class1();
	}

	public int MyValue { get; set; }

	public Class1 MyClass1 { get; init; }

	public void OnGet()
	{
		MyValue = MyClass1.MyValue;
	}
}
