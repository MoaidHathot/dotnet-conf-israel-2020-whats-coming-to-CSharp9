<Query Kind="Program" />

void Main()
{
	var age = 10;
	
	if(age is < 13)
	{
		"Child".Dump();
	}

	if (age is > 13 && age is < 18)
	{
		"Teenager".Dump();
	}
}

// You can define other methods, fields, classes and namespaces here
