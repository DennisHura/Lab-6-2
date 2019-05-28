using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_4s_l6_2
{
    class Program
    {
        static public void Search(BookInLibrary[] bookinlibrary)
        {
            try
            {

                int codeS;
                bool flag = false;
                Console.WriteLine("\n\nВведите код книги для поиска");
                codeS = int.Parse(Console.ReadLine());
                Console.WriteLine("Результат поиска:\n");
                for (int i = 0; i < bookinlibrary.Length; i++)
                {
                    if (codeS == bookinlibrary[i].code)
                    {
                        bookinlibrary[i].ToString();
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Такой книги нет в списке");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("!!! Неверный формат ввода кода книги !!!");
            }
        }

        static public void CompareAuthor(BookInLibrary[] bookinlibrary)
        {
            int i1, i2;
        again1:
            Console.WriteLine($"Введите номер 1-й книги для сравнения(от 0 до {bookinlibrary.Length - 1})");
            i1 = int.Parse(Console.ReadLine());
            if (i1 > bookinlibrary.Length || i1 < 0)
            {
                goto again1;
            }
        again2:
            Console.WriteLine($"Введите номер 2-й книги для сравнения(от 0 до {bookinlibrary.Length - 1})");
            i2 = int.Parse(Console.ReadLine());
            if (i2 > bookinlibrary.Length || i2 < 0)
            {
                goto again2;
            }
            if (bookinlibrary[i1].pib == bookinlibrary[i2].pib)
            {
                Console.WriteLine($"Книги {bookinlibrary[i1].nazva} и {bookinlibrary[i2].nazva} имеют одного автора");
            }
            else
            {
                Console.WriteLine($"Книги {bookinlibrary[i1].nazva} и {bookinlibrary[i2].nazva} имеют разных авторов");
            }
        }


        static public void ComparePages(BookInLibrary[] bookinlibrary)
        {
            int i1, i2;
        again1:
            Console.WriteLine($"Введите номер 1-й книги для сравнения(от 0 до {bookinlibrary.Length - 1})");
            i1 = int.Parse(Console.ReadLine());
            if (i1 > bookinlibrary.Length || i1 < 0)
            {
                goto again1;
            }
        again2:
            Console.WriteLine($"Введите номер 2-й книги для сравнения(от 0 до {bookinlibrary.Length - 1})");
            i2 = int.Parse(Console.ReadLine());
            if (i2 > bookinlibrary.Length || i2 < 0)
            {
                goto again2;
            }
            if (bookinlibrary[i1].pages == bookinlibrary[i2].pages)
            {
                Console.WriteLine($"Книги {bookinlibrary[i1].nazva} и {bookinlibrary[i2].nazva} имеют одинаковое количество страниц");
            }
            else
            {
                if (bookinlibrary[i1].pages > bookinlibrary[i2].pages)
                {
                    Console.WriteLine($"В книге {bookinlibrary[i1].nazva} страниц больше чем в книге {bookinlibrary[i2].nazva} на {bookinlibrary[i1].pages - bookinlibrary[i2].pages}");
                }
                else
                {
                    Console.WriteLine($"В книге {bookinlibrary[i2].nazva} страниц больше чем в книге {bookinlibrary[i1].nazva} на {bookinlibrary[i2].pages - bookinlibrary[i1].pages}");
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                BookInLibrary x1 = new BookInLibrary("Игра престолов", 1996, 569);
                BookInLibrary x2 = new BookInLibrary("Битва королей", 1998, 600);
                BookInLibrary x3 = new BookInLibrary("Буря мечей", 2000, 541);
                BookInLibrary x4 = new BookInLibrary("Лисенко", "Методические указания", 9485, 2019, 10, "информация");
                BookInLibrary x5 = new BookInLibrary("Даниель Дефо", "Робинзон Крузо", 9343, 1985, 300, "приключенческий роман");
                BookInLibrary x6 = new BookInLibrary();

                BookInLibrary[] books = new BookInLibrary[] { x1, x2, x3, x4, x5, x6 };

                books[5].getInfo(5);
                for (int i = 0; i < books.Length; i++)
                {
                    books[i].ToString();
                }

                Search(books);
                Console.WriteLine("\n\n");
                CompareAuthor(books);
                Console.WriteLine("\n\n");
                ComparePages(books);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Список книг пуст");
            }
        }
    }
}
