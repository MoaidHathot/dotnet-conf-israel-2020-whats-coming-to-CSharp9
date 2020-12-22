<Query Kind="Program" />

void Main()
{
	
}

double CalculateDiscount(double price)
{
	return price switch
	{
		double p when p < 100 => 0.0,
		double p when p < 200 => 3.0,
		double p when p < 1000 => 5.0,
		_ => 10.0
	}
}


