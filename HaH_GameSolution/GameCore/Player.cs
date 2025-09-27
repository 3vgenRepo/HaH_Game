namespace GameCore
{
	public class Player : Creature
	{
		private int _healingCounter = 0;
		public int HealingCounter
		{
			get => _healingCounter;
			set
			{
				_healingCounter = _healingCounter < 4 ? value : 4;
			}
		}

		public Player(int attack, int armor, int health, int[] damage, bool isAlive = true)
		{
			this.Attack = attack;
			this.Armor = armor;
			this.Health = health;
			this.Damage = damage;
			this.IsAlive = isAlive;
		}

		public void Heal()
		{
			if(HealingCounter <= 4)
			{
				Health += (int) (Health * 0.3);
				HealingCounter++;
			}
		}
	}
}
