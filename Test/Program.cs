Player p1 = new Player();
p1.name = "Rat";
Player p2 = new Player();
p2.name = "JoeShmoe";

p1.Commando();
p2.Loader();
Console.WriteLine(p1.name+" Has spawned");
Console.WriteLine(p2.name+" Has spawned");

Wisp w1 = new Wisp();
Wisp w2 = new Wisp();
Console.WriteLine(w1.name+" Has spawned");
Console.WriteLine(w2.name+" Has spawned");

w1.hp -= 10;
w2.hp -= 30;

Vagrant wv1 = new Vagrant();
Console.WriteLine(wv1.name+" Has spawned");

w2.hp -= 20;
w1.hp -= 40;
wv1.hp -= 500;
Console.WriteLine(w1.name+" Was Defeated");
Console.WriteLine(w2.name+" Was Defeated");

p1.hp -= 100;
p2.hp -= 200;

Console.WriteLine(p1.name+" Has Died");
Console.WriteLine(p2.name+" Has Died");
Console.WriteLine("Game Over!");


Console.ReadLine();