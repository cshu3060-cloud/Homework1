using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
public class Book
{



    public string title;
    public string author;
    public int pageCount;
    public bool isBorrowed;
    public decimal price;

    public Book(string bookTile, string bookAuthor, int pages, decimal bookPrice)
    {
        title = bookTile;
        author = bookAuthor;
        pageCount = pages;
        price = bookPrice;
        isBorrowed = false;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"书名：{title}");
    }
    public void BorrowBook()
    {
        isBorrowed = true;
        Console.WriteLine($"《{title}》已被借出");
    }
    public void ReturnBook()
    {
        isBorrowed= false;
        Console.WriteLine($"<<{title}>>已归还");
    }
    public void CheckStatus()
    {
        string status = isBorrowed ? "已借出" : "可借阅";
            Console.WriteLine($"<<{title}>>状态；{status}");
    }


    public void checkbooktype()
    {
        int deposit = 0;
        // 控制流
        switch (deposit)
        {
            case 0:
                Console.WriteLine($"deposite = {deposit}");
                break;
            case 1:
                ///222
                break;


        }

        if (pageCount < 100)
        {

            Console.WriteLine($"《{deposit}》是中篇书籍");
        }
        else if (pageCount >= 100 && pageCount <= 300 &&
            pageCount >= 450 && pageCount <= 600)
        {
            Console.WriteLine($"《{title}》是中篇书籍");
        }
        else
        {
            Console.WriteLine(($"《{title}》是中篇书籍"));
        }


    }
}

//Book book1 = new Book("C#编程入门", "张三"，250,45,5m);
//Book book2 = new Book("python基础"，"李四", 80,)；
//    Console.WriteLine("===书籍信息===");
//book1.DisplayInfo();
//book1.Checkbooktype();
//book1.CheckStatus ();
//Console.WriteLine("\n===借书操作===");
//book1.BorrowBook ();
//book1.CheckStatus();
//Console.WriteLine("\n===还书操作===");
//book1.BorrowBook();
//book1.CheckStatus();
//Console.WriteLine("\n===另一本书===");
//book1.DisplayInfo ();
//book2.CheckbookType ();

