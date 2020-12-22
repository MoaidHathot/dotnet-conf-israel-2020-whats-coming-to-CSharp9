<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	Foo(new Dictionary<string, string>());
	Foo(new ());
	Foo(new (10));
	Foo(new () { ["FirstName"] = "Moaid", ["LastName"] = "Hathot" });
}

static void Foo(Dictionary<string, string> map)
{
	
}

