namespace Server.Pages
{
	/// <summary>
	/// Runtime Error!
	/// </summary>
	public class Learn03Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn03Model(Infrastructure.Learn03.Class1 class1) : base()
		{
			MyClass1 = class1;
		}

		public Infrastructure.Learn03.Class1 MyClass1 { get; }

		public void OnGet()
		{
		}
	}
}

//namespace Server.Pages
//{
//	/// <summary>
//	/// Runtime Error!
//	/// </summary>
//	public class Learn03Model :
//		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
//	{
//		public Learn03Model(Infrastructure.Learn03.Class1? class1) : base()
//		{
//			MyClass1 = class1;
//		}

//		public Infrastructure.Learn03.Class1? MyClass1 { get; }

//		public void OnGet()
//		{
//		}
//	}
//}

//namespace Server.Pages
//{
//	/// <summary>
//	/// OK!
//	/// </summary>
//	public class Learn03Model :
//		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
//	{
//		public Learn03Model(Infrastructure.Learn03.Class1? class1 = null) : base()
//		{
//			MyClass1 = class1;
//		}

//		public Infrastructure.Learn03.Class1? MyClass1 { get; }

//		public void OnGet()
//		{
//		}
//	}
//}
