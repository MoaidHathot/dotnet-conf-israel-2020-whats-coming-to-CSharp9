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
		=> obj is Person other && (FirstName, LastName) == (other.FirstName, other.LastName);

	public override int GetHashCode()
		=> (FirstName, LastName).GetHashCode();
}
