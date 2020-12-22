<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	List<Action> actions = new ();

	for (var index = 0; index < 10; ++index)
	{
		actions.Add(Foo);

		static void Foo()
		{
			$"This is iteration {index}".Dump();
		}
	}

	foreach (var action in actions)
	{
		action();
	}


}
