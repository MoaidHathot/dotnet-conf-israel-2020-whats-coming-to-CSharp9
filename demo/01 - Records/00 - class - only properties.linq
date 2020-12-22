<Query Kind="Program" />

void Main()
{
	var moaid = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
}

public class Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
}
