namespace GameCore
{
	public class Monster : Creature
	{
		public Monster(string name, int attack, int armor, int health, int[] damage, bool isAlive = true) : base(name)
		{
			Attack = attack;
			Armor = armor;
			Health = health;
			Damage = damage;
			IsAlive = isAlive;
		}
	}
}
