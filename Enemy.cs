public class Enemy
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void PerformAttack(Enemy target, Attack chosenAttack)
    {
        int damage = chosenAttack.DamageAmount;
        target.Health -= damage;
        Console.WriteLine($"{Name} attacks {target.Name}, dealing {damage} damage!");
        Console.WriteLine($"{target.Name}'s health is now {target.Health}");
    }
}