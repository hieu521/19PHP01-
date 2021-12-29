using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helllooo
{
    class IO
    {
            public static void PrintMenu()
    {
        Console.WriteLine("******************menu*******************");
        Console.WriteLine("WELLCOME TO STUDENT MANGEMENT APPLICATION");
    }
    public static void greeting()
    {
        Console.WriteLine("\t\t see you again....");

    }
    public static int EnterMenuOptions()
    {
        Console.WriteLine("\t\tMENU OPTIONS");
        Console.WriteLine("\t   1. ADD NEW STUDENT");
        Console.WriteLine("\t2. PRINT ALL STUDENTS INFO");
        Console.WriteLine("\t3. REMOVE STUDENT BY GRADE");
        Console.WriteLine("\t4. UPDATE STUDENT BY GRADE");
        Console.WriteLine("\t\t 5. EXIT");
        Console.Write("ENTER YOUR CHOICE:");
        return int.Parse(Console.ReadLine());
    }
    public static void ToScreen(string str)
    {
        Console.WriteLine(str);
    }
    public static string EnterStringValue()
    {
        return Console.ReadLine();
    }
    public static int EnterIntValue()
    {
        return int.Parse(Console.ReadLine());
    }
    public static int EnterStudentId()
    {
        Console.Write("id:");
        return int.Parse(Console.ReadLine());
    }
    public static string EnterStudentName()
    {
        Console.Write("name : ");
        return Console.ReadLine();
    }
    public static int EnterStudentAge()
    {
        Console.Write("age: ");
        return int.Parse(Console.ReadLine());
    }
    public static string EnterStudentMajor()
    {
        Console.Write("major: ");
        return Console.ReadLine();
    }
    public static string EnterStudentClass()
    {
        Console.Write("class: ");
        return Console.ReadLine();
    }
    public static string EnterStudentGrade()
    {
        Console.Write("grade:  ");
        return Console.ReadLine();
    }
    public static void InputError()
    {
        Console.WriteLine("INVALID INPUT !!!");
    }
    public static void ShowMessage(bool status)
    {
        if (status)
        {
            Console.WriteLine("SUCCESSED!!!");
        }
        else
        {
            Console.WriteLine("FAILED!!!");
        }
    }
}
}
