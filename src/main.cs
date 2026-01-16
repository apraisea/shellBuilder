Console.Write("$ ");

var command = Console.ReadLine();
string[] knownCommands = { };
if (!knownCommands.Contains(command))
{
    Console.WriteLine($"{command}: command not found");
}
