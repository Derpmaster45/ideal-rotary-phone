namespace TextadventureFramework
{
    class Weapon
    {
        private string WeaponName{get;set;}\
        private double WeaponDamage{get;set;}
        private float WeaponCost{get;set;}
        
        // weapon shop menu

         WeaponShop(Player playercharacter)
        {
            string weaponShopChoice="";
             while(weaponShopChoice=="")
             {
                 Console.WriteLine("Hello, how can I help you?\n 1: Buy\n 2) Sell\n3)Back\n");
                 weaponShopChoice=Console.ReadLine();
                 switch(weaponShopChoice.ToLower())
                 {
                         case"1"
                         case"buy":
                            Console.WriteLine("What would you like to buy?");
                            // loop through the shop inventory. 10-9-26 will be added later.
                         break;

                 }
             }
        }
    }
}
