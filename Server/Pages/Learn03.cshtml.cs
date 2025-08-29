using Infrastructure.Learn03;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

// **************************************************
// Runtime Error!
// **************************************************
public class Learn03Model : PageModel
{
	//public Learn03Model() : base()
	//{
	//	MyClass1 = new();
	//}

	public Learn03Model(Class1 class1) : base()
	{
		MyClass1 = class1;
	}

	public Class1 MyClass1 { get; init; }

	public void OnGet()
	{
	}
}
// **************************************************

// **************************************************
// لوس‌بازی
// Runtime Error!
// **************************************************
//public class Learn03Model : PageModel
//{
//	public Learn03Model(Class1? class1) : base()
//	{
//		MyClass1 = class1;
//	}

//	public Class1? MyClass1 { get; init; }

//	public void OnGet()
//	{
//	}
//}
// **************************************************

// **************************************************
// OK!
// لوس‌بازی
// **************************************************
//public class Learn03Model : PageModel
//{
//	public Learn03Model(Class1? class1 = null) : base()
//	{
//		MyClass1 = class1;
//	}

//	public Class1? MyClass1 { get; init; }

//	public void OnGet()
//	{
//	}
//}
// **************************************************
