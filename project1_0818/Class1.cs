public class Student 
{
    public int Age;
    private int Grade;
    public string Name;
    public bool Gender;    
    public Student(int age, int grade, string name,bool gender)
    {
        Age = age;
        Grade = grade;
        Name = name;
        Gender = gender; 
    }
    public Student() { }
    public Student(int age, int grade, string name)
    {
        Age = age;
        Grade = grade;
        Name = name;
    }
    public void Add(int value1, int value2) 
    { 
        int result = value1 + value2;
        Console.WriteLine("结果为："+result);
    }
    public void Greet()
    {
        Console.WriteLine("北京欢迎您！");
    }
    public void Max(int value3,int value4)
    {
        if (value4 > value3)
        {
            Console.WriteLine("结果为" + value4);
        }
        else
        {
            Console.WriteLine("结果为" + value3);
        }
    }
    public void Print_sequence(int n) 
    {
        int result= n;
        Console.WriteLine("结果为：" + result);
    }
    public void Circle_area(float value5)
    {
        float result = value5 * value5 * 3.1415926f;
        Console.WriteLine("结果为：" + result);
    }
    public void Introduce()
    {
        Console.WriteLine($"我叫{Name}, 今年{Age}岁, 读{Grade}年级");
    }
    public int TellMyGrade()
    {
        return 0;
    }

    
}
