public class Mage : Character, IAttack
{
    public Mage(string name) : base(name)
    {
    }
    public void Attack()
    {
        Console.WriteLine($"{Name} casts a powerful spell!");
    }
}