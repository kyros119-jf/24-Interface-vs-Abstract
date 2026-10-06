public abstract class Character
{
    public string Name { get; set; }

    public Character(string name)
    {
        Name = name;
    }   
}

public interface IAttack
{
    void Attack();
}