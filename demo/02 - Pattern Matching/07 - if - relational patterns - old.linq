<Query Kind="Program" />

void Main()
{
	
}

double CalculateDiscount(double price)
{
	if (price < 100)
	{
		return 0.0;
	}
	
	if(price < 200)
	{
		return 3.0;
	}
	
	if(price < 1000)
	{
		return 5.0;
	}
	
	return 10;
}


