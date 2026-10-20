//using TextadventureFramework.Character;
	//using TextadventureFramework.Enemy;
namespace TextadventureFramework
{
class BattleSystem
    {
		public static double DoDamageToPlayer(Character target, Enemy attacker)
		{
			double damagedealt=target.playerdefensebase/attacker.enemystrength;
			Console.WriteLine($"You take {damagedealt} ponts of damage\n");
			return damagedealt;
		}
			public static double AttackEnemy(Character player, Enemy target)
			{
				double damagedealttotarget=player.playerstrength/target.enemybasedefense;
				Console.WriteLine($"You have dealt {damagedealttotarget} points of damage");
				return damagedealttotarget;
			}
			static void ShowErrorMessage(string message)
		{
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ForegroundColor=ConsoleColor.White;
		}
		public static void Start (Character player, Enemy target)
		{
			Console.WriteLine($"{target.enemyname} has appeared!");
			// default player goes first
			while (player.playercurrenthealth<=0||target.enemycurrenthealth<=0)
			{
				
				string battleoption="";
				while (battleoption=="")
				{
					Console.WriteLine("What will you do? \n 1) Attack \n 2) defend");
					battleoption=Console.ReadLine();
					switch(battleoption.ToLower())
					{
						case "1":
						case "attack":
						// do damage function goes here.
						AttackEnemy(player,target);
						break;
						case"2":
						case "defend":
						DoDamageToPlayer(player,target);
						break;
						default:
						ShowErrorMessage("Please choose from the options listed \n 1) attack \n 2)defend");
						battleoption="";
						break;
						
					
					}
				}
			}
		}
    }
}
