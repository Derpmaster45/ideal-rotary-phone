namespace TextadventureFramework{
    

class Character
{
    // player information feel free to change default values to match your level scalying 
    private string PlayerName="";
    private double PlayerHealth=100;
    private int PlayerLevel=1;
    private int PlayerDefenseBase=25;
    private double PlayerExp=0;
    private double ExpToNextLevel=250;
    private string PlayerClass="";
    private string PlayerTextColor="";
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
    }
}