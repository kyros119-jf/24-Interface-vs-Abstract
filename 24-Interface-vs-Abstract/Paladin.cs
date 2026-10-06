public class Paladin : Character, IAttack
{
    public Paladin(string name) : base(name)
    {
    }
    public void Attack()
    {
        Console.WriteLine($"{Name} attacks with a holy strike!");
    }
}