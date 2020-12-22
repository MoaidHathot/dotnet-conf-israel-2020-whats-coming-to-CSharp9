<Query Kind="Program" />

void Main()
{
	object obj = null;

	(obj switch
	{
		int => 666,
		string => ((string)obj).Length
		StringBuilder => ((StringBuilder)obj).Length,
		null => 0,
		_ => obj.GetHashCode()
	}).Dump();
}
