using CompanyManagement.Models;

public class Program
{
    static void Main()
    {
        Client client1 = new Client(name: "SnowTech Solutions", email: "info@snowtech.com");
        Client client2 = new Client(name: "Spencer Harston", email: "spencer.harston@students.snow.edu");

        Console.WriteLine(client1.GetSummary());
        Console.WriteLine();
        Console.WriteLine(client2.GetSummary());
    }
}