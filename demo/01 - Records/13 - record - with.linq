<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	var moaid = new Person("Moaid", "Hathot")
	{
		MiddleName = "Jr.",
	};
	
	var haneen = moaid with { FirstName = "Haneen", MiddleName = null };
	var clone = moaid with { };

	moaid.ToString().Dump();
	haneen.ToString().Dump();
	clone.ToString().Dump();
	(moaid == clone).Dump();
}

public record Person(string FirstName, string LastName)
{
	public string MiddleName { get; init; }
}

public record Developer(string FirstName, string LastName, string[] ProgrammingLanguages) : Person(FirstName, LastName);
