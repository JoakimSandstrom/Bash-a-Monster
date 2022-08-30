public class Player
{
    public string name = "Player";
    // Potition and rotation
    public float x;
    public float y;
    public float z;
    public float xr;
    public float yr;
    public float zr;
    // Stats
    public int lv = 1;
    public int xp = 0;
    public int hp;
    public float damage;
    public float armor;
    public float moveSpd;
    public float attackSpd;
    // Status
    public int[] effects = new int[75];
    // Items
    public int[] items = new int[148];
    public int[] equipment = new int[38];
    public void Commando()
    {
        name = "Commando";
        hp = 100;
        damage = 10;

    }
}

