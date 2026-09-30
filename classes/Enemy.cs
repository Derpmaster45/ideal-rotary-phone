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
        get=>enemybasedefense;
        set=> enemybasedefense=value;
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
}
}