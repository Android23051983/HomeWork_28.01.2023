// See https://aka.ms/new-console-template for more information
using static System.Console;
//Person person = new("Том");
//инициализация для третьего способа
//Person person = new() { Name = "Bred" };
Person ted = new Person() { Name = "Ted", Age = 22 };
WriteLine(person.Name);
//WriteLine(person.Email);

//первый способ
/*public class Person
{
    public string Nmae { get; init; } = "Undefined";
}*/

//Второ1 способ
/*public class Person
{
    public Person(string name) => Name = name;
    public string Name { get; init; }
}*/

//третий способ
/*public class Person
{
    public string Name { get; init; } = "";
}*/

//четвёртый способ

/*public class Person
{
    string name = "";
    public string Name
    {
        get{ return name; }
        init
        {
            name = value;
            Email = $"{value}@gmail.com";
        }
    }

    public string Email { get; init; }
}*/

//required
/*public class Person
{ 
  
    public required string Name { get; set; }
    public required int Age { get; set; }

    
}*/
