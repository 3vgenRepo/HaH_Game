namespace GameCore
{
	public abstract class Creature
	{
		private readonly string _name;

		protected Creature(string name)
		{
			_name = name.Length > 0 ? name : throw new Exception("Assignment error. Name can't be empty.");
		}

		private bool _isAlive;
		private int _attack;
		private int _armor;
		private int _health;
		private int[] _damage = new int[2];

		public string Name => _name;

		public bool IsAlive { get => _isAlive; set => _isAlive = value; }

		public int Attack
		{
			get => _attack;
			set
			{
				_attack = (value > 0 && value <= 30) ? value : throw new Exception("Assignment error. The attack parameter must be between 1 and 30.");
			}
		}

		public int Armor
		{
			get => _armor;
			set
			{
				_armor = (value > 0 && value <= 30) ? value : throw new Exception("Assignment error. The armor parameter must be between 1 and 30.");
			}
		}

		public int Health
		{
			get => _health;
			set
			{
				if (value > 0)
				{
					_health = value;
				}
				else
				{
					_health = 0;
					_isAlive = false;
				}
			}
		}

		public int[] Damage
		{
			get => _damage;
			set
			{
				if (value[0] >= 0 && value[1] >= 0)
				{
					if(value[0] > value[1])
					{
						_damage[0] = value[1];
						_damage[1] = value[0];
					}
					else
					{
						_damage = value;
					}						
				}
				else
				{
					throw new Exception("Assignment error. Damage parameter must be array (int[]) with 2 positive value.");
				}
			}
		}

		public static bool CactulateAttack(Creature attacker, Creature defending)
		{
			int attackModifier = attacker.Attack - defending.Armor + 1;

			do
			{
				Random rand = new Random();
				int nextAttackChance = rand.Next(1, 7);

				if (nextAttackChance == 5 || nextAttackChance == 6)
				{
					defending.Health -= rand.Next(attacker.Damage[0], attacker.Damage[1] + 1);
					return true;
				}
			} while (attackModifier-- > 0);

			return false;
		}

		public override string ToString()
		{
			return $"Creature {Name}, IsAlive = {IsAlive}, Health = {Health}, Attack = {Attack}, Armor = {Armor}, Damage = {Damage[0]}-{Damage[1]}.";
		}
	}
}
