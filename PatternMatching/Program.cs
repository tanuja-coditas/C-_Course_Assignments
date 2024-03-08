using System;

class Person
{
    public string name;
    public int age;
    public virtual void Greet()
    {
        Console.WriteLine("Hello Person");
    }
}

class Employee : Person
{
    public string department;
    /*public override void Greet()
    {
        Console.WriteLine("Hello Employee");
    }*/
}
public delegate void MyDelegate();
class Program
{
    static void Main()
    {
        Person person = new Employee();

        person.name = "Tanuja";
        person.age = 18;
        person.Greet();
        
       // Employee employee = (Employee)person;
       if(person is Employee employee)
        {
            employee.department = "HR";
            MyDelegate myDelegate = employee.Greet;
            myDelegate();
        }
        

        /*Console.WriteLine(employee.name);
        Console.WriteLine(employee.age);
        Console.WriteLine(employee.department);
        employee.Greet();*/


       

       
    }
}