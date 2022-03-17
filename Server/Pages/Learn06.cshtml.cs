namespace Server.Pages
{
	public class Learn06Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn06Model
			(Infrastructure.Learn06.Interface2 interface2) : base()
		{
			Interface2 = interface2;
		}

		public Infrastructure.Learn06.Interface2 Interface2 { get; }

		public void OnGet()
		{
		}
	}
}
