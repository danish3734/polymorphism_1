// See https://aka.ms/new-console-template for more information
using System;

// Create an interface called IQuittable with a void method Quit()
public interface IQuittable
{
    void Quit();
}

// Modify the Employee class to inherit from IQuittable and implement the Quit() method
public class Employee : IQuittable
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate an Employee object
        Employee employee = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit() method on the IQuittable object (polymorphism)
        quittableEmployee.Quit(); // Output: John Doe has quit the job.

        // Wait for user input to close the console window
        Console.ReadLine();
    }
}

