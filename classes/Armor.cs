namespace TextadventureFramework
{
    class Armor
    {
        private string ArmorName{get;set;}
        private double ArmorPrice {get;set;}
        private double ArmorDefensePoints {get;set;}
        private static string[] ShopInventory{get; set;}=Array.Empty<string>();
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
					for(int shopInventoryCounter=0; shopInventoryCounter<Armor.ShopInventory.Length; shopInventoryCounter++)
					{
						for(int shopPriceCounter=0; shopPriceCounter<Armor.ShopInventory.Length; shopPriceCounter++)
						{
							Console.WriteLine(ShopInventory[shopInventoryCounter][shopPriceCounter]);
						}
						
						//Console.Writeline()
					
					}
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
