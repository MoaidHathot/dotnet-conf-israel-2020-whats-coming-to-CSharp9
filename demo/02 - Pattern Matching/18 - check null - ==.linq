<Query Kind="Program" />

void Main()
{
	Person obj = new Person();
	
	if(obj == null)
	{
		"Person is null".Dump();
	}
}

public class Person
{
	public string Name { get; init; }
	
	public static bool operator ==(Person p1, Person p2)
		=> p1.Name == p2.Name;

	public static bool operator !=(Person p1, Person p2)
		=> !(p1 == p2);
}

