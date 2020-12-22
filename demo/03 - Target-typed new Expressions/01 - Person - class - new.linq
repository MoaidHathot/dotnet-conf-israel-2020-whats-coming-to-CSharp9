<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	Person person = new ("Moaid", "Hathot");
}

public class Person
{
	public string FirstName { get; }
	public string LastName { get; }

	public Person(string firstName, string lastName)
		=> (FirstName, LastName) = (firstName, lastName);
}