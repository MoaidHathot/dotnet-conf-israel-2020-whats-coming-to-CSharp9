<Query Kind="Program" />

void Main()
{
	string obj = null;

	if (obj is { Length: 10 })
	{
		10.Dump();
	}

	if (obj is { Length: var length })
	{
		length.Dump();
	}
}
