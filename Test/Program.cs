Wisp w1 = new Wisp();
Player p1 = new Player();
p1.name = "Rat";
w1.hp -= 10;


p1.Commando();

Vagrant wv1 = new Vagrant();

wv1.name = "Bert";


Console.WriteLine(w1.name+" Is At "+w1.hp+" HP");
Console.WriteLine(wv1.name+" Has Joined The Battle");


Console.ReadLine();