public class Melee : Enemy
{
    private readonly Random random = new Random();
    private readonly Attack[] attacks = {
        new Attack("Punch", 20),
        new Attack("Kick", 15),
        new Attack("Tackle", 25)
    };

    public Melee(string name) : base(name, 120)
    {
    }

    public void Rage()
    {
        Attack chosenAttack = attacks[random.Next(attacks.Length)];
        chosenAttack = new Attack(chosenAttack.Name, chosenAttack.DamageAmount + 10); // Modify damage amount
        PerformAttack(this, chosenAttack);
    }
}