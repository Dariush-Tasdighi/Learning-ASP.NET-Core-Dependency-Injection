namespace Infrastructure.Learn05
{
	public class Class1_2 : object, Interface1
	{
		public Class1_2() : base()
		{
			MyValue = 20;
		}

		public int MyValue { get; set; }
	}
}
