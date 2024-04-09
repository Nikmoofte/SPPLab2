
using System.Security.Cryptography.X509Certificates;

var faker = new DTOFiller.Faker();
var empl = faker.Create<Employee>();
var empl2 = faker.Create<Employee>();

var notEmpl = faker.Create<NotEmploee>();
var notEmpl2 = faker.Create<NotEmploee>();

Console.WriteLine(empl.ToString());
Console.WriteLine(empl2.ToString());

Console.WriteLine(notEmpl.ToString());
Console.WriteLine(notEmpl2.ToString());

; ;;;;

public class NotEmploee
{
    public NotEmploee() { }
    public float aaa { get; set; }
    public bool bbb { get; set; }
    public byte bbb2 { get; set; }

    public string ToString()
    {
        return $"aaa: {aaa}, bbb: {bbb}, bbb2: {bbb2}";
    }
}

public class Employee
{
    public Employee()
    {
        //...populate the properties here
    }

    public int Id { get; set;}
    public string Name { get; set; }    
    public DateTime DateOfJoining { get; set;}
    //..other domain operations
    public NotEmploee notEmploee { get; set; }
    override public string ToString()
    {
        return $"Id: {Id}, Name: {Name}, DateOfJoining: {DateOfJoining}, NotEmlpoe:   " + notEmploee.ToString();
    }
}
// See https://aka.ms/new-console-template for more information
