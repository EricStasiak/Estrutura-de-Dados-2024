using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1 = new Person ("Eric Dobler Stasiak", 18);
Console.WriteLine(person1.Name);

Person person2 = new Person ();
person2.Name = "Makoto Yuki";
person2.Age = 16;
Console.WriteLine(person2.Name);

Person person3 = new Person ()
{
    Name = "Leonel Brizola",
    Age = 80
};
Console.WriteLine(person3.Name);
