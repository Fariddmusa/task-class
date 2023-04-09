internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public bool isGraduated;

    public void  GetFullName()
    {
        Console.WriteLine(Name + " " + Surname);
    }
    public string GetFullInfo()
    {
        string info = $"{Name} {Surname},{Group},{Point}";

        if (isGraduated)
        {
            info += ",Mezun olub";
        }
        else 
        {
            info+= ",Mezun olmayib";
        }
        if (Point > 80)
        {
            info += ",Gire biler";
        }
        else if  (Point <= 80)
        {
            info += ",Gire bilmez";
        }
        return info ;
    }
}
   
        
   
