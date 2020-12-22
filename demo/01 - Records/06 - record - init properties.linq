<Query Kind="Program" />

void Main()
{
	var moaid = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
	
	moaid.ToString().Dump();
}

public record Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
}
