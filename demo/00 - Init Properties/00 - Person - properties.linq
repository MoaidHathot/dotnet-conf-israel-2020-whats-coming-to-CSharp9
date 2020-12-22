<Query Kind="Program" />

void Main()
{
	var moaid = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};

	moaid.Dump();
}

public class Person
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
}
