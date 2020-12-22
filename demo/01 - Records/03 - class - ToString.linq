<Query Kind="Program" />

void Main()
{
	var moaid = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};
}

public class Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }

	public override bool Equals(object obj)
		=> Equals(obj as Person);

	public bool Equals(Person other)
		=> other is { } && (FirstName, LastName) == (other.FirstName, other.LastName);

	public override int GetHashCode()
		=> (FirstName, LastName).GetHashCode();

	public override string ToString()
		=> $"FirstName: '{FirstName}', LastName: '{LastName}'";
}
