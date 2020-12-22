<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	
}

public interface ICodeParser { };

public abstract class IDE
{
	public abstract ICodeParser GetParser();
}

public class Compiler : ICodeParser { };
public class Interpreter : ICodeParser { };

public class CSharpIDE : IDE
{
	public override ICodeParser GetParser()
		=> new Compiler();
}

public class PythonIDE : IDE
{
	public override ICodeParser GetParser()
		=> new Interpreter();
}