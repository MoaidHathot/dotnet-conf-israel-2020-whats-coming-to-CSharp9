<Query Kind="Program" />

void Main()
{
	bool isCompiled = true;

	ICodeParser parser = isCompiled ? new Compiler() : new Interpreter();
}

public record Test();

public interface ICodeParser { };

public class Compiler : ICodeParser { };
public class Interpreter : ICodeParser { };