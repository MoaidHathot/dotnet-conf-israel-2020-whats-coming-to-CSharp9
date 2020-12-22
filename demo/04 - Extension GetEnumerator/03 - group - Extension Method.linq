<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Text.RegularExpressions</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	Group group = new (new ("Moaid", "Hathot"), new ("Haneen", "Hathot"));

	foreach (var person in group)
	{
		person.Dump();
	}
}


public record Group(params Person[] Persons);

public record Person(string FirstName, string LastName);

public static class Extensions
{
	public static IEnumerator<Person> GetEnumerator(this Group group)
		=> ((IEnumerable<Person>)group.Persons).GetEnumerator();
}