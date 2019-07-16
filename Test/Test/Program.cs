using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country("Казахстан"));
            int menu = 0;
            bool isExit = false;
            while (!isExit)
            {
                Console.Clear();
                Console.WriteLine("1 - Создание \n2 - Изменение \n3 - Удаление \n4 - Поиск по имени \n0 - Выход");
                Console.Write("Выберите пункт меню: ");
                menu = ChooseMenu(ref menu, 0, 4);
                Console.Clear();
                switch (menu)
                {
                    case 0: isExit = true; break;
                    case 1:
                        Create(countries);
                        break;
                    case 2:
                        Change(countries);
                        break;
                    case 3:  break;
                }
            }
        }

        static public void Change(List<Country> countries)
        {
            int menu = 0;
            int index = 0;
            int indexForField = 0;

            Console.WriteLine("1 - Название страны \n2 - Название культуры \n3 - план полива культуры \n0 - Возврат в главное меню");
            Console.Write("Выберите что вы хотите изменить: ");
            menu = ChooseMenu(ref menu, 0, 3);
            Console.Clear();
            switch (menu)
            {
                case 0: break;
                case 1:
                    Console.WriteLine("Выберите страну: ");
                    foreach (var country in countries)
                    {
                        Console.WriteLine($"{index++} - {country.GetName()}");
                    }
                    index = ChooseMenu(ref index, 0, countries.Count - 1);
                    Console.Write("Введите новое имя: ");
                    countries[index].SetName(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Выберите страну, в котором хотите изменить название культуры: ");
                    foreach (var country in countries)
                    {
                        Console.WriteLine($"{index++} - {country.GetName()}");
                    }
                    index = ChooseMenu(ref index, 0, countries.Count - 1);
                    Console.WriteLine("Выберите культуру: ");
                    for (int i = 0; i < countries[index].GetSize(); i++)
                    {
                        Console.WriteLine($"{i} - {countries[index][i].GetCulture(i).GetName()}");
                    }
                    indexForField = ChooseMenu(ref indexForField, 0, countries[index].GetSize() - 1);
                    Console.WriteLine("Введите новое название культуры: ");
                    countries[index][indexForField].SetCultureName(indexForField, Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Выберите страну, в котором хотите изменить план культуры: ");
                    foreach (var country in countries)
                    {
                        Console.WriteLine($"{index++} - {country.GetName()}");
                    }
                    index = ChooseMenu(ref index, 0, countries.Count - 1);
                    Console.WriteLine("Выберите культуру: ");
                    for (int i = 0; i < countries[index].GetSize(); i++)
                    {
                        Console.WriteLine($"{i} - {countries[index][i].GetCulture(i).GetName()}");
                    }
                    indexForField = ChooseMenu(ref indexForField, 0, countries[index].GetSize() - 1);
                    Console.WriteLine("Введите новый план культуры: ");
                    countries[index][indexForField].SetCulturePlan(indexForField, Console.ReadLine());
                    break;
            }
        }
        

        static public void Create(List<Country> countries)
        {
            int menu = 0;
            int index = 0;
            Console.WriteLine("1 - Страна \n2 - Поле \n3 - Культуру \n 0 - Возврат в главное меню");
            Console.Write("Выберите что вы хотите создать: ");
            menu = ChooseMenu(ref menu, 0, 3);
            Console.Clear();
            switch (menu)
            {
                case 0: break;
                case 1:
                    Console.Write("Введите название страны: ");
                    countries.Add(new Country(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Выберите страну, в которую хотите добавить поле: ");
                    foreach (var country in countries)
                    {
                        Console.WriteLine($"{index++} - {country.GetName()}");
                    }
                    index = ChooseMenu(ref index, 0, countries.Count - 1);
                    countries[index].AddField();
                    break;
                case 3:
                    Console.WriteLine("Выберите страну, в которую хотите добавить Культуру: ");
                    foreach (var country in countries)
                    {
                        Console.WriteLine($"{index++} - {country.GetName()}");
                    }
                    index = ChooseMenu(ref index, 0, countries.Count - 1);
                    countries[index].AddField();
                    Console.WriteLine("Введите название и план полива для культуры: ");
                    countries[index][countries[index].GetSize() - 1].AddCulture(Console.ReadLine(), Console.ReadLine());
                    break;
            }
        }
        
        static public int ChooseMenu(ref int menu, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out menu) && (menu <= max && menu >= min))
                {
                    break;
                }
                else
                {
                    Console.Write("Неккоректный выбор пункта! Выберите заново: ");
                }
            }
            return menu;
        }

    }
}
