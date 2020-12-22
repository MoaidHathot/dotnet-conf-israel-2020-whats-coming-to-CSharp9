<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	Foo((string first, string last) =>
	{
		DateTime.Now.ToString("o").Dump();
	});
}

public void Foo(Action<string, string> action)
{
	action("Moaid", "Hathot");
}


