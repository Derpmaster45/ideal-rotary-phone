namespace TextadventureFramework
{
	class PotionShop
	{
		public string[] PotionDetails{get; set;}=Array.Empty<string>();
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
					break;
					case"sell":
					case"2":
					break;
					case"3":
					case"exit":
					break;
				}
			}
		} 
	}
}
