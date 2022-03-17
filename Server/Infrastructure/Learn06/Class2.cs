namespace Infrastructure.Learn06
{
	public class Class2 : object, Interface2
	{
		public Class2(Interface1 interface1) : base()
		{
			MyValue2 = 60;
			Interface1 = interface1;
		}

		public int MyValue2 { get; set; }

		public Interface1 Interface1 { get; }
	}
}
