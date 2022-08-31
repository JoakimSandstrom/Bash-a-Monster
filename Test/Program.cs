Player p1 = new Player();

Console.WriteLine("Welcome To My Stupid Game!");
Console.WriteLine("");
Console.WriteLine("Choose Your Name:");
p1.name = Console.ReadLine();
Console.WriteLine("Choose Your Class: 1.Commando | 2.Loader");
if (Console.ReadLine() == "1")
{
    p1.Commando();
}
else if (Console.ReadLine() == "2")
{
    p1.Loader();
}
else
{
    return;
}

Console.WriteLine("Starting...");

Console.WriteLine(p1.name+" Has Spawned");


Console.WriteLine("Start the Teleporter Event?(y/n)");
if (Console.ReadLine() == "y")
{
    Vagrant wv1 = new Vagrant();
    Console.WriteLine(wv1.name+" Has Spawned");
    Console.WriteLine("The Boss One Shots You...");
    Console.WriteLine("Game Over!");
}
else
{
    Console.WriteLine("You Stand Around Doing Nothing. You Eventualy die.");
    Console.WriteLine("Game Over!");
}

Console.ReadLine();