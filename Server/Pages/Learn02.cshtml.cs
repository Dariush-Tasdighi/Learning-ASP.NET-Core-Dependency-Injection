namespace Server.Pages
{
	public class Learn02Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn02Model() : base()
		{
			//MyClass1 =
			//	new Infrastructure.Learn02.Class1();

			MyClass1 = new();
		}

		public int MyValue { get; set; }

		public Infrastructure.Learn02.Class1 MyClass1 { get; }

		public void OnGet()
		{
			MyValue =
				MyClass1.MyValue;
		}
	}
}
