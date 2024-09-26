using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Student : Person
{
    public string StudentID { get; set; }

    public  void ShowInfo()
    {
        base.ShowInfo(); // Gọi phương thức ShowInfo() của lớp cha
        Console.WriteLine($"Student ID: {StudentID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        
        Console.WriteLine("nhap name:");
        student.Name = Console.ReadLine();
        Console.WriteLine("nhap age:");
        student.Age = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("nhap StudentID:");
        student.StudentID = Console.ReadLine();
        student.ShowInfo();
    }
}
