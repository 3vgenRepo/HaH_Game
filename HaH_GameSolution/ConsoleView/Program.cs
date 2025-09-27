using GameCore;

internal class Program
{
	private static void Main(string[] args)
	{
		do
		{
			Console.WriteLine("Привет друг! Давай поиграем в простую игру.");
			//Console.WriteLine("Для тебя я создам персонажа. Тебе лишь нужно определить его характеристики.");

			try
			{
				//while (true) 
				//{
				//	Console.Write("Для начала введи имя для своего персонажа: ");
				//	string? name = Console.ReadLine();
				//	Console.WriteLine();
					
				//	if (name != null)
				//		break;
				//	else
				//		Console.WriteLine("Ошибка! Имя не может быть null.");
				//}

				//Console.Write("Хорошо! Теперь введи значения атаки (целое чисто от 1 до 30): ");
				//int attack = int.Parse(Console.ReadLine());
				//Console.WriteLine();

				//Console.Write("Хорошо! Теперь введи значения защиты (целое чисто от 1 до 30): ");
				//int armor = int.Parse(Console.ReadLine());
				//Console.WriteLine();

				//Console.Write("Хорошо! Теперь введи значение максимального здоровья (натуральное число): ");
				//int health = int.Parse(Console.ReadLine());
				//Console.WriteLine();

				//Console.Write("Хорошо! Теперь введи значение урона (натуральное число) от: ");
				//int damageStart = int.Parse(Console.ReadLine());
				//Console.Write(" (натуральное число) до: ");
				//int damageEnd = int.Parse(Console.ReadLine());
				//Console.WriteLine();

				//int[] damage = { damageStart, damageEnd };

				Player player = new Player("Player1", 10, 30, 50, [1, 6]);
				Monster monster = new Monster("Monster1", 8, 10, 50, [1, 6]);

				do
				{
					Console.WriteLine(player.ToString());
					Console.WriteLine(monster.ToString());
					Creature.CactulateAttack(player, monster);
					Creature.CactulateAttack(monster, player);
				} while (player.IsAlive && monster.IsAlive);

				if (player.IsAlive)
				{
					Console.WriteLine("Вы победили!");
				}
				else
				{
					Console.WriteLine("Увы. Монстр оказался сильнее.");
				}

			}
			catch (Exception e) { Console.WriteLine(e.Message); break; }

			Console.ReadLine();
		} while (true);
		
	}
}