<Query Kind="Program" />

void Main()
{
	object age = 10;
	
	if (age is int and < 13 or > 18)
	{
		"Too young or too old".Dump();
	}
}
