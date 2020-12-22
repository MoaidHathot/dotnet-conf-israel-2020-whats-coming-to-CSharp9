<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	var persons = new Person[]
	{
		new ("Moaid", "Hathot"),
		new ("Haneen", "Hathot"),
	};
}

public record Person(string FirstName, string LastName);