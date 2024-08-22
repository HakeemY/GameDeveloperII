public class Magic : Enemy
{
    private readonly Attack[] attacks = {
        new Attack("Fireball", 25),
        new Attack("Lightning Bolt", 20),
        new Attack("Staff Strike", 10)
    };

    public Magic(string name) : base(name, 80)
    {
    }

    public void Heal(Enemy target)
    {
        if (target is Magic) // Check if the target is of type Magic
        {
            ((Magic)target).Health += 40; // Cast target to Magic to access Health property
            Console.WriteLine($"{Name} heals {target.Name} for 40 health. {target.Name}'s health is now {target.Health}.");
        }
        else
        {
            Console.WriteLine($"Cannot heal {target.Name}. Target is not a Magic caster.");
        }
    }
}