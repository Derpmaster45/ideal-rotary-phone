namespace TextadventureFramework{
    

class Character
{
    // display error message
    void DisplayErrorMessage(string message)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor=ConsoleColor.White;
    }
    // player information feel free to change default values to match your level scalying 
    private string PlayerName="";
    private double PlayerHealth=100;
    private int PlayerLevel=1;
    private int PlayerDefenseBase=25;
    private double PlayerExp=0;
    private double ExpToNextLevel=250;
    private string PlayerClass="";
    private string PlayerTextColor="";
    // create a variable for the list
    
    // error message variable 
    string message="";
    // getters and setters
    public string playername
    {
        get=>PlayerName;
        set=>PlayerName=value;
    }
    public double playerhealth
    {
        get=>PlayerHealth;
        set=> PlayerHealth=value;
        
    }
    public int playerlevel
    {
        get=> PlayerLevel;
        set=> PlayerLevel=value;
    }
    public int playerdefensebase
    {
        get=> PlayerDefenseBase;
        set=> PlayerDefenseBase=value;
    }
    public double playerexp
    {
        get=>PlayerExp;
        set=>PlayerExp=value;
    }
    public double exptonextlevel
    {
        get=>ExpToNextLevel;
        set=>ExpToNextLevel=value;
    }
    public string playerclass
    {
        get=> PlayerClass;
        set=>PlayerClass=value;
    }
    
    void setTextColor(string textcolor)
    {
        Console.WriteLine("What text color would you want to use for your Character(s)");
        textcolor=Console.ReadLine();
        switch(textcolor.ToLower())
        {
                case"black":
                Console.ForegroundColor=ConsoleColor.Black;
                    break;
                case"red": 
                Console.ForegroundColor=ConsoleColor.Red;
                break;
        }
    }
        public Character CreateCharacter() 
        {
            Character player=new Character();
            Console.WriteLine("What is your characters name?");
            player.playername=Console.ReadLine();
            Console.WriteLine("What class is your player?\n 1) tbd\n 2)tbd\n3)tbd"); // left up to devs 
           while(player.playerclass=="")
           {
                player.playerclass=Console.ReadLine();
            switch(player.playerclass.ToLower())
            {
                    /* note defaults for these cases can be and should be changed. use this case to set defaults for each 
                     * class. 
                    */
                    case"1":
                    player.playerhealth=100;
                    player.playerdefensebase=25;
                    player.playerexp=0;
                    player.exptonextlevel=250;
                    player.playerclass="tbd1";
                    player.playerlevel=1;
                    break;

                    case"2":                    
                    case"tbd2":
                    player.playerhealth=150;
                    player.playerdefensebase=25;
                    player.playerexp=0;
                    player.exptonextlevel=250;
                    player.playerclass="tbd2";
                    player.playerlevel=1;
                    break;

                    case"3":
                    case"tbd3":
                    player.playerhealth=100;
                    player.playerdefensebase=75;
                    player.playerexp=0;
                    player.exptonextlevel=250;
                    player.playerclass="tbd3";
                    player.playerlevel=1;
                    break;

                default:
                    message="Please select from the 3 listed options /n1) tbd \n2)tbd\n3)tbd";
                    DisplayErrorMessage(message);
                    player.playerclass="";
                    break;
            }
           }
            return player;
        }
    }
}
