using System;

class abstract_cls
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter ID:");
        string sid = Console.ReadLine();
        Console.WriteLine("Enter Grade:");
        double grd = Convert.ToDouble(Console.ReadLine());


        Undergraduate undergrad1 = new Undergraduate
        {
            Name = name,
            StudentId = sid,
            Grade = grd

        };
        Console.WriteLine("Name is:"+ undergrad1.Name);
        Console.WriteLine("Student ID is:"+ undergrad1.StudentId); 
        Console.WriteLine("Grade is: "+ undergrad1.Grade);
        Console.WriteLine("'The result for undergraduate, if student is passed':"+ undergrad1.IsPassed());


        Graduate grad1 = new Graduate
        {
            Name = name,
            StudentId = sid,
            Grade = grd
        };
        Console.WriteLine("Name is:" + grad1.Name);
        Console.WriteLine("Student ID is:" + grad1.StudentId);
        Console.WriteLine("Grade is:" + grad1.Grade);
        Console.WriteLine("'The result for graduate, if student is passed':" + grad1.IsPassed());
        Console.ReadLine();
    }
}

public abstract class Student
{
    public string Name { get; set; }
    public string StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed();
}


public class Undergraduate : Student
{
    public override bool IsPassed()
    {
        return Grade > 70.0;
    }
}

public class Graduate : Student
{
    public override bool IsPassed()
    {
        return Grade > 80.0;

    }
}

