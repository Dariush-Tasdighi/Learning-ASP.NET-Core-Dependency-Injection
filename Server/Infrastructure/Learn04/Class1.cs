namespace Infrastructure.Learn04;

/// <summary>
/// Error! This class is not Stateless!
/// </summary>
public class Class1 : object
{
	public Class1() : base()
	{
		MyValue = 10;
	}

	public int MyValue { get; set; }
}
