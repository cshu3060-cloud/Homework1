// See https://aka.ms/new-console-template for more information


chenshu chenshu = new chenshu();
Student Weipeng=new Student( );
Player Pone = new Player();

Weipeng.Add(5, 8);
Weipeng.Greet();


int value = 1;
for (int i = 1; i <= 20; i++)
{
    if (value % 3 == 0 || value % 5 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else
    {
        Console.WriteLine(value);
    }
    value = value + 1;
}

