Wisp w1 = new Wisp();
Wisp w2 = new Wisp();

w1.name = "Cringe";
w2.name = "Rat";

w1.hp -= 10;

Vagrant wv1 = new Vagrant();

wv1.name = "Bert";


Console.WriteLine(w1.name+" Is At "+w1.hp+" HP");
Console.WriteLine(w2.name+" Is At "+w2.hp+" HP");
Console.WriteLine(wv1.name+" Has Joined The Battle");


Console.ReadLine();