namespace Infrastructure.Learn01;

public class Class2 : object
{
	// در این حالت سازنده پیش‌فرض وجود ندارد
	//public Class2() : base()
	//{
	//}

	public Class2(Class1 class1) : base()
	{
		MyClass1 = class1;
	}

	public Class1 MyClass1 { get; init; }
}
