namespace Infrastructure.Learn04;

public class Class2 : object
{
	public Class2(Class1 myClass1) : base()
	{
		MyClass1 = myClass1;
	}

	public Class1 MyClass1 { get; init; }
}
