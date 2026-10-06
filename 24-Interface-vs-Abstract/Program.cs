IAttack[] attackers =
{
    new Paladin("Sir Galahad"),
    new Mage("Merlin")
};

foreach (IAttack attacker in attackers )
{ 
    attacker.Attack();
}
