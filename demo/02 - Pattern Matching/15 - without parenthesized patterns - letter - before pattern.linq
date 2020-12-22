<Query Kind="Program" />

void Main()
{
	IsLetter('m');
}

public static bool IsLetter(this char c) =>
	c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';