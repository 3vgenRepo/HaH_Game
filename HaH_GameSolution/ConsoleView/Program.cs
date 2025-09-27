using GameCore;

internal class Program
{
	private static void Main(string[] args)
	{
		Player player = new Player("Player1", 10, 20, 100, [1, 6]);
		Monster monster = new Monster("Monster1", 8, 10, 100, [1, 3]);

		Console.WriteLine(player.ToString());
		Console.WriteLine(monster.ToString());

		Creature.CactulateAttack(player, monster);
	}
}