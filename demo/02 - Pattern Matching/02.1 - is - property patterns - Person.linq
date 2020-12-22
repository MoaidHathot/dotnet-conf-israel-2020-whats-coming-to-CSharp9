<Query Kind="Program" />

void Main()
{	
	Person person = new Person("Moaid", "Jr", "Hathot");

	if (person is { })
	{
		"Person is not null".Dump();
	}

	if (person is { MiddleName: { } })
	{
		"MiddleName is not null".Dump();
	}

	if (person is { MiddleName: { Length: var length } })
	{
		$"MiddleName's length is '{length}'".Dump();
	}
}

public record Person(string FirstName, string MiddleName, string LastName)
