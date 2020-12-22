<Query Kind="Program" />

void Main()
{
	var moaid = new Person
	{
		FirstName = "Moaid",
		LastName = "Hathot",
	};

	var developer = new Developer
	{
		FirstName = "Moaid",
		LastName = "Hathot",
		ProgrammingLanguages = new string[] { "C#", "Java", "Python", "C++", "Processing", "JavaScript", "TypeScript" },
	};

	moaid.ToString().Dump();
	developer.ToString().Dump();
}

public record Person
{
	public string FirstName { get; init; }
	public string LastName { get; init; }
}

public record Developer : Person
{
	public string[] ProgrammingLanguages { get; init; }
	
	protected override bool PrintMembers(StringBuilder builder)
	{
		if(base.PrintMembers(builder))
		{
			builder.Append(", ");	
		}

		var languages = ProgrammingLanguages is null ? "null" : $"[ {string.Join(", ", ProgrammingLanguages)} ]";
		
		builder.Append($"{nameof(ProgrammingLanguages)} = {languages}");
		return true;
	}
}
