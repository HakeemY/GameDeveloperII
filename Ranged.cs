public class Ranged : Enemy
{
    private int distance = 5;

    private readonly Attack[] attacks = {
        new Attack("Shoot an Arrow", 20),
        new Attack("Throw a Knife", 15)
    };

    public Ranged(string name) : base(name, 100)
    {
    }

    public void Dash()
    {
        distance = 20;
        Console.WriteLine($"{Name} dashes forward, setting distance to {distance}.");
    }

    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (distance >= 10)
        {
            base.PerformAttack(target, chosenAttack);
        }
        else
        {
            Console.WriteLine($"{Name} is too far away to perform an attack!");
        }
    }
}