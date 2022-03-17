namespace Infrastructure.Learn01
{
	public class Class2 : object
	{
		public Class2(Class1 class1) : base()
		{
			MyClass1 = class1;
		}

		public Class1 MyClass1 { get; set; }
	}
}
