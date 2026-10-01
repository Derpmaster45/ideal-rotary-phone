namespace TextadventureFramework{
class Enemy : Character
{
    // class attributes feel free to modify default vaules.
    private string EnemyName="";
    private double EnemyHealth=100;
    private double EnemyBaseDefense=25;
    private int ExpValue=50; 
    private int EnemyLevel=1;
    
    // getters and setters
    public string enemyname
    {
        get=> EnemyName;
        set => EnemyName=value;
        
    }
    public double enemyhealth
    {
        get=> EnemyHealth;
        set=>EnemyHealth=value;
        
    }
    public double enemybasedefense
    {
        get=>EnemyBaseDefense;
        set=>EnemyBaseDefense=value;
    }
    public int expvalue
    {
        get=>ExpValue;
        set=>ExpValue=value;
    }
    public int enemylevel
    {
        get=>EnemyLevel;
        set=>EnemyLevel=value;
        
    }
    public Enemy CreateEnemy(string name, double health,double defense, int expvalue, int level)
    {
        Enemy echaracter= new Enemy();
        try{
        echaracter.enemyname=name;
        echaracter.enemyhealth=health;
        echaracter.enemybasedefense=defense;
        echaracter.expvalue=expvalue;
        echaracter.enemylevel=level;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
        return echaracter;
    }
}
}