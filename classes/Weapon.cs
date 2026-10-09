namespace TextadventureFramework
{
    class Weapon
    {
        private string WeaponName{get;set;}
        private double WeaponDamage{get;set;}
        private float WeaponCost{get;set;}
        private float WeaponSellPrice{get;set;}
         // string message="";
        
        
        static void ShowErrorMessage(string message)
        {
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ForegroundColor=ConsoleColor.White;
        }
        // weapon shop menu

        public static void WeaponShop(Character playercharacter)
        {
            string weaponShopChoice="";
             while(weaponShopChoice=="")
             {
                 Console.WriteLine("Hello, how can I help you?/n 1: Buy/n 2) Sell/n3)Back/n");
                 weaponShopChoice=Console.ReadLine();
                 switch(weaponShopChoice.ToLower())
                 {
                         case"1":
                         case"buy":
                            Console.WriteLine("What would you like to buy?");
                            // loop through the shop inventory. 10-9-26 will be added later.
                         break;
                     case "2":
                     case"sell":
                     Console.WriteLine("What would you like to sell/n");
                     // loop through player inventory along with selling prices.
                         break;
                     default:
                    // string message="Please choose ffrom the above options/n1) buy /2 sell/n";
                     ShowErrorMessage("Please choose from the above options/n1) buy /2 sell/n");
                     weaponShopChoice="";
                        break;

                 }
             }
        }
    }
}
