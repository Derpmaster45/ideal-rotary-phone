namespace TextadventureFramework
{
    class Armor
    {
        private string ArmorName{get;set;}
        private double ArmorPrice {get;set;}
        private double ArmorDefensePoints {get;set;}
        
        public static void ShowErrorMessage(string message)
        {
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ForegroundColor=ConsoleColor.White;
		}
        public static void ArmorShop(Character player)
        {
			string shopChoice="";
			while (shopChoice=="")
			{
				Console.WriteLine("Hello, how can i help you today?/n1)Buy/n2)sell/n3)back/n");
				shopChoice=Console.ReadLine();
				switch(shopChoice.ToLower())
				{
					case"1":
					case"buy":
					// loop through shops inventory
					break;
					case"2":
					case"sell":
					// loop through player inventory
					break;
					case "3":
					case"exit":
					break; 
					default:
					ShowErrorMessage("Please select from the above options \n1) buy /n 2)sell/n3)exit shop");
					break;
				}
			}
		}
    }
}
