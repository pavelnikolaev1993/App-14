Cat marta = new Cat("Кошка");
marta.Showinfo();
Dog reks = new Dog("Собака");
reks.Showinfo();




abstract class Animal
{ 
public abstract string Name { get; set;  }

    public Animal(string name)
    { 
    Name = name;
    }
    public abstract void Say();
   
    public void Showinfo()
    {
        
        Console.WriteLine(Name);
        Say();

    }
   
}
class Cat : Animal
{
    private string say;
    private string name;
    public override string Name
    {
        get => name;
        set => name = value;
    }
    public Cat(string name)
        :base(name)
    {
       
    }
    public override void Say()
    {
        Console.WriteLine("Мяу");
    }



}
class Dog : Animal
{
    private string say;
    private string name;
    public override string Name
    {
        get => name;
        set => name = value;
    }
    public Dog(string name)
        : base(name)
    {
        
    }
    public override void Say()
    {
        Console.WriteLine("Гав");
    }



}

