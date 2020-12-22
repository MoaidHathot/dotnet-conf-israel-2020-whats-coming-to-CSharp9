<Query Kind="Program" />

void Main()
{
	object obj = null;

	switch (obj)
	{
		case int:
			666.Dump();
			break;
		case string: 
			((string)obj).Length.Dump();
			break;
		case StringBuilder:
			((StringBuilder)obj).Length.Dump();
			break;
		case null:
			0.Dump();
			break;
		default: 
			obj.GetHashCode().Dump();
			break;
	}
}
