namespace Infrastructure.Learn04;

/// <summary>
/// Bad Practice! This class is not Stateless!
/// </summary>
public class Class1 : object
{
	public Class1() : base()
	{
		MyValue = 10;
	}

	public int MyValue { get; set; }
}
