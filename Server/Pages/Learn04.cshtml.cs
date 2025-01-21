using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Server.Pages;

// **************************************************
public class Learn04Model : PageModel
{
	public Learn04Model(Infrastructure.Learn04.Class1 class1) : base()
	{
		MyClass1 = class1;
	}

	public Infrastructure.Learn04.Class1 MyClass1 { get; init; }

	public void OnGet()
	{
		MyClass1.MyValue++;
	}
}
// **************************************************

// **************************************************
//public class Learn04Model : PageModel
//{
//	public Learn04Model(Infrastructure.Learn04.Class1 class1) : base()
//	{
//		MyClass1 = class1;
//	}

//	private object theObject = new object();

//	public Infrastructure.Learn04.Class1 MyClass1 { get; init; }

//	public void OnGet()
//	{
//		// نیست Threadsafe دستور ذیل
//		MyClass1.MyValue++;

//		//lock (theObject)
//		//{
//		//	MyClass1.MyValue++;
//		//}
//	}
//}
// **************************************************

// **************************************************
//public class Learn04Model : PageModel
//{
//	public Learn04Model(Infrastructure.Learn04.Class2 myClass2) : base()
//	{
//		MyClass2 = myClass2;
//	}

//	public Infrastructure.Learn04.Class2 MyClass2 { get; init; }

//	public void OnGet()
//	{
//	}
//}
// **************************************************
