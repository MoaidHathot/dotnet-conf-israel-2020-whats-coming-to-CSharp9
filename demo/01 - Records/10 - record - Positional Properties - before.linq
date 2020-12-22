<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");
	var developer = new Developer("Moaid", "Hathot", new string[] { "C#", "Java", "Python", "C++", "Processing", "JavaScript", "TypeScript" })
	
	var (first, last, programmingLanguages) = developer;
}

public record Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
	
	public Person(string firstName, string lastName)
		=> (FirstName, LastName) = (firstName, lastName);
}

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
