using System.ComponentModel.Design;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

public class Cat
{
    public string Name;
    public int Age;


    public void Meow()
    {
        Console.WriteLine(Name + "喵喵叫");
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + Age);
    }
}
//public class Student
//{
//    public string Name;
//    public int score = 0;

//    public void GetGrade()
//    {
//        if (score >= 90)
//        {
//            Console.WriteLine("优秀");
//        }
//        else if (score >= 60 && score <= 89)
//        {
//            Console.WriteLine("及格");
//        }
//        else
//        {
//            Console.WriteLine("不及格");
//        }
//    }
//}
    //public int Score(>=1&&<=20)
    //{
    //    if (Score / 3)
    //    {
    //        Console.WriteLine("Fizz")
    //    }
    //    else if (Score / 5)
    //    {
    //        Console.WriteLine("Buzz")
    //    }
    //    else if (Score / 3 && Score / 5)
    //    {
    //        Console.WriteLine("FizzBuzz")
    //     }
    //    else
    //    {
    //        Console.WriteLine(Score)
    //}
    //}




