
public class Vagrant
{
    public string name = "Wandering vagrant";
    // Potition and rotation
        public float x;
        public float y;
        public float z;
        public float rx;
        public float ry;
        public float rz;
    // Stats
        public int hp = 1500;
        public float damage;
        public float armor;
        public float moveSpd;
        public float attackSpd;
    // Items
        public int[] items = new int[148];
    // Status
        public int[] effects = new int[75];
        public int elite;
        public string target;
        public int nextAttack;
        public bool underQuarterHp;
}
