<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");

	moaid.Dump();
}

public class Person
{
	public string FirstName { get; }
	public string LastName { get; }
	
	public Person(string firstName, string lastName)
		=> (FirstName, LastName) = (firstName, lastName);
}
