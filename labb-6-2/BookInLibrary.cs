using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog_4s_l6_2
{
    public class BookInLibrary : IComparable
    {
        public string pib;
        public string nazva;
        public int code;
        private int year;
        public int pages;
        private string genre;



        public BookInLibrary(string nazva, int year, int pages)
        {
            pib = "Джордж Мартин";
            this.nazva = nazva;
            code = 1783;
            this.year = year;
            this.pages = pages;
            genre = "Фэнтези";
        }
        public BookInLibrary(string pib, string nazva, int code, int year, int pages, string genre)
        {
            this.pib = pib;
            this.nazva = nazva;
            this.code = code;
            this.year = year;
            this.pages = pages;
            this.genre = genre;
        }

        public BookInLibrary() { }
        public int CompareTo(object o)
        {
            BookInLibrary one = (BookInLibrary)o;
            return year.CompareTo(one.year);
        }
        public void getInfo(int i)
        {
            Console.WriteLine($"Введите информацию о книге № {i}");
            Console.Write("Введите название: ");
            nazva = Console.ReadLine();
            Console.Write("Введите фио автора: ");
            pib = Console.ReadLine();
            Console.Write("Введите код: ");
            code = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Введите kol-vo str: ");
            pages = int.Parse(Console.ReadLine());
            Console.Write("Введите жанр: ");
            genre = Console.ReadLine();

        }
        public override string ToString()
        {
            Console.WriteLine("Книга: {0}, автор {1}, код {2}, год {3}, сожержится страниц {4}, жанр {5}", nazva, pib, code, year, pages, genre);
            return "Книга: " + nazva + " автор " + pib + " код " + code + " год " + year + " сожержится страниц " + pages + " жанр " + genre;
        }

    }
}