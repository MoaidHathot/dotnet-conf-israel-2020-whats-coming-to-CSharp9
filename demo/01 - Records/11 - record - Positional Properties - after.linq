<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");
	var developer = new Developer("Moaid", "Hathot", new string[] { "C#", "Java", "Python", "C++", "Processing", "JavaScript", "TypeScript" })

	var (firstName, lastName) = moaid;
	var (first, last, programmingLanguages) = developer;
}

public record Person(string FirstName, string LastName);

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
