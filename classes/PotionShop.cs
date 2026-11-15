namespace TextadventureFramework
{
	class PotionShop
	{
		public static string[] PotionDetails{get; set;}=Array.Empty<string>();
		private double StoreGold{get;set;}
		public static void PotionShopMenu(PotionShop shop, Character player)
		{
			// prompt the user for what they would like to do
			string shopchoice="";
			while(shopchoice=="")
			{
				Console.WriteLine("What would you like ot do?\n 1) Buy\n 2)Sell/3) exit");
				shopchoice = Console.ReadLine();
				switch(shopchoice.ToLower())
				{
					case"1":
					case"buy":
					string buyChoice="";
					while(buyChoice=="")
					{
						for(int shopInventoryCounter=0; shopInventoryCounter<PotionDetails.Length;shopInventoryCounter++)
						{
							Console.WriteLine(PotionDetails[shopInventoryCounter]);
						}
						Console.WriteLine("What would you like to buy?\n");
						buyChoice=Console.ReadLine();
					}
					break;
					case"sell":
					case"2":
					string sellChoice="";
					while(sellChoice=="")
					{
						for(int ShopInventoryCounter=0;ShopInventoryCounter<PotionDetails.Length; ShopInventoryCounter++)
						{
							Console.WriteLine(player.PlayerInventory[ShopInventoryCounter]);
						}
						Console.WriteLine("What would you like to sell");
					}
					break;
					case"3":
					case"exit":
					break;
				}
			}
		} 
	}
}
