<Query Kind="Program" />

void Main()
{
	
}

double CalculateDiscount(double price)
{
	return price switch
	{
		< 100 => 0.0,
		< 200 => 3.0,
		< 1000 => 5.0,
		_ => 10.0
	}
}


