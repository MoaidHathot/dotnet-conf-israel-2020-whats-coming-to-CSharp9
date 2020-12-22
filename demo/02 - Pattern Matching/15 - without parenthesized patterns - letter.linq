<Query Kind="Program" />

void Main()
{
	IsLetter('m');
}

public static bool IsLetter(this char c) =>
	c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';