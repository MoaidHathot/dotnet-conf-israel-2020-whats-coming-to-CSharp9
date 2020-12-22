<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	Person p = new ()
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
}

public record Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
}
