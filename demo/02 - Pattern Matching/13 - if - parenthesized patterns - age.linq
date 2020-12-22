<Query Kind="Program" />

void Main()
{
	var age = 10;
	
	if (age is (> 13) and (> 18))
	{
		"Too young or too old".Dump();
	}
}
