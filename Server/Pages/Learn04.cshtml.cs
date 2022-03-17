namespace Server.Pages
{
	public class Learn04Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn04Model
			(Infrastructure.Learn04.Class1 class1) : base()
		{
			MyClass1 = class1;
		}

		public Infrastructure.Learn04.Class1 MyClass1 { get; }

		public void OnGet()
		{
			MyClass1.MyValue++;
		}
	}
}
