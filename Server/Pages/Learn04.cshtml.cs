using Infrastructure.Learn04;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

// **************************************************
/// <summary>
/// 04 / 01 - 04 / 02
/// </summary>
public class Learn04Model : PageModel
{
	public Learn04Model(Class1 class1) : base()
	{
		MyClass1 = class1;
	}

	public Class1 MyClass1 { get; init; }

	public void OnGet()
	{
		MyClass1.MyValue++;
	}
}
// **************************************************


// **************************************************
///// <summary>
///// 04 / 02
///// </summary>
//public class Learn04Model : PageModel
//{
//	public Learn04Model(Class1 class1) : base()
//	{
//		MyClass1 = class1;
//	}

//	/// <summary>
//	/// Threadsafe
//	/// </summary>
//	private object theObject = new();
//	public Class1 MyClass1 { get; init; }

//	public void OnGet()
//	{
//		// نیست Threadsafe دستور ذیل
//		//MyClass1.MyValue++;

//		// Threadsafe
//		lock (theObject)
//		{
//			MyClass1.MyValue++;
//		}
//	}
//}
// **************************************************

// **************************************************
///// <summary>
///// 04 / 03
///// </summary>
//public class Learn04Model : PageModel
//{
//	public Learn04Model(Class2 myClass2) : base()
//	{
//		MyClass2 = myClass2;
//	}

//	public Class2 MyClass2 { get; init; }

//	public void OnGet()
//	{
//	}
//}
// **************************************************
