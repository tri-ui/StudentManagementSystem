using System;

namespace Assignment1
{
    internal class Program
    {
        private int a;

        private static void Main(string[] args)
        {
            StudentManage cabin = new StudentManage();
         
            Menu menu = new Menu("----***------Student manager-----***-----");
            menu.addContent("1. Show all information of Student");
            menu.addContent("2. Add Student");
            menu.addContent("3. Search Student");
            menu.addContent("4. Update Student's Information");
            menu.addContent("5. Exit");
            int choice;
            bool flag = false;
            do
            {
                do
                {
                    menu.showMenu();
                    Console.Write("Your Choice: ");
                    choice = int.Parse(Console.ReadLine());
                    flag = cabin.checkIntInRange(0, 5, choice);
                    if (flag)
                    {
                        Console.WriteLine("Please choosing number in range 1 - 5");
                    }
                } while (flag);

                switch (choice)
                {
                    case 1:
                        cabin.showAllInfo();
                        break;

                    case 2:
                        cabin.addStudent();
                        break;

                    case 3:
                        cabin.searchStudent();
                        break;

                    case 4:
                        cabin.updateStudentById();
                        break;

                    default:
                        Console.WriteLine("Goodbye.");
                        break;
                }
            } while (choice != 5);
            Console.WriteLine();
        }
    }
}