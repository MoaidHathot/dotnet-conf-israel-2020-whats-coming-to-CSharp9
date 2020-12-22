<Query Kind="Program" />

void Main()
{
	object obj = "something"
	
	if(obj is string)
	{
		(obj as string).Length.Dump();
		((string)obj).Length.Dump();
	}
}
