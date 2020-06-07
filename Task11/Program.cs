using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task11
{
    public class SortByName : IComparer
    {
        public int Compare(object ob1, object ob2)
        {
            MyClassLibrary10.Person s1 = (MyClassLibrary10.Person)ob1;
            MyClassLibrary10.Person s2 = (MyClassLibrary10.Person)ob2;
            if (String.Compare(s1.Name, s2.Name, true) > 0) return 1;
            if (String.Compare(s1.Name, s2.Name, true) < 0) return -1;
            return 0;
        }
    }
    class Program
    {
        static void Menu(ref List<MyClassLibrary10.Person> list)
        {
            Console.WriteLine("Выбирите действие:1- добавить элемент , 2- удалить элемент; 0- выйти из меню ");
            bool vvod_ok = false;
            string str;
            int choice;
            while (!vvod_ok)
            {
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 0)
                    {
                        return;
                    }
                    if (choice == 1)
                    {
                        Add(ref list);
                        vvod_ok = true;
                        Console.WriteLine("Выбирите действие:1- добавить элемент , 2- удалить элемент; 0- выйти из меню ");
                    }
                    if (choice == 2)
                    {
                        Delete(ref list);
                        vvod_ok = true;
                        Console.WriteLine("Выбирите действие:1- добавить элемент , 2- удалить элемент; 0- выйти из меню ");
                    }
                    if (choice != 1 && choice != 2 && choice != 0)
                    {
                        Console.WriteLine("Введите число из  предложенных");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите целое положительное число из предложенных");

                }
            }
        }
        #region добавить list
        static void Add(ref List<MyClassLibrary10.Person> list)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Выбирите тип нового элемента:\n 1- Служащий; 2- Рабочий; 3- Инженер; 0- Выход в меню");
                bool vvod_ok = false;
                while (!vvod_ok)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0) return;
                        if (choice == 1)
                        {
                            MakeEmployee(ref list);
                            vvod_ok = true;
                        }
                        if (choice == 2)
                        {
                            MakeWorker(ref list);
                            vvod_ok = true;
                        }
                        if (choice == 3)
                        {
                            MakeEngineer(ref list);
                            vvod_ok = true; Console.WriteLine("Выбирите тип нового элемента:\n 1- Служащий; 2- Рабочий; 3- Инженер; 0- Выход в меню");
                        }
                        if (choice != 1 && choice != 2 && choice != 3 && choice != 0)
                        {
                            Console.WriteLine("Введите число из  предложенных");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите целое положительное число из предложенных");
                    }
                }
            }
        }

        static void MakeEmployee(ref List<MyClassLibrary10.Person> list)
        {
            string name;
            int age = 0, experience = 0;
            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя ");
            
            name = Convert.ToString(Console.ReadLine());
          
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }

            list.Add(new MyClassLibrary10.Employee() { Name = name,  Age = age, Experience = experience });
            Console.WriteLine("Элемент добавлен");
        }
        static void MakeWorker(ref List<MyClassLibrary10.Person> list)
        {
            string name, workplace;
            int age = 0, experience = 0;
            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя");
           
            name = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Место работы ");
            workplace = Convert.ToString(Console.ReadLine());
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }

            list.Add(new MyClassLibrary10.Worker() { Name = name, Age = age, Experience = experience, WorkPlace = workplace });
            Console.WriteLine("Элемент добавлен");
        }
        static void MakeEngineer(ref List<MyClassLibrary10.Person> list)
        {
            string name, qualification;
            int age = 0, experience = 0;
            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя");
           
            name = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Квалификация ");
            qualification = Convert.ToString(Console.ReadLine());
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }

            list.Add(new MyClassLibrary10.Engneer() { Name = name, Age = age, Experience = experience, Qualification = qualification });
            Console.WriteLine("Элемент добавлен");
        }
        #endregion

        #region удалить list
        static void Delete(ref List<MyClassLibrary10.Person> list)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1- Удалить по номеру ;2- Удалить по ключу ; 0- Выход в меню");
                bool vvod_ok = false;
                while (!vvod_ok)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0) return;
                        if (choice == 1)
                        {
                            DeleteOnNumber(ref list);
                            vvod_ok = true;
                        }
                        if (choice == 2)
                        {
                            DeleteOnKey(ref list);
                            vvod_ok = true;
                        }

                        if (choice != 1 && choice != 2 && choice != 3 && choice != 0)
                        {
                            Console.WriteLine("Введите число из  предложенных");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите целое положительное число из предложенных");
                    }
                }
            }
        }
        static void DeleteOnNumber(ref List<MyClassLibrary10.Person> list)
        {
            int i = 1, number = 0;
            bool vvod_ok = false;
            foreach (MyClassLibrary10.Person item in list)
            {
                Console.WriteLine(i);
                item.PrintInfo();
                Console.WriteLine();
                i++;
            }

            Console.WriteLine("Выбирите номер для удаления: ");
            while (!vvod_ok)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > list.Count)
                    {
                        Console.WriteLine("Номер превысил границы списка");
                    }
                    else
                    {
                        vvod_ok = true;
                        list.RemoveAt(number - 1);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите целое положительное число");
                }
            }
            Console.WriteLine("Список после удаления элемента: ");
            i = 1;
            foreach (MyClassLibrary10.Person item in list)
            {
                Console.WriteLine(i);
                item.PrintInfo();
                Console.WriteLine();
                i++;
            }
        }
        static void DeleteOnKey(ref List<MyClassLibrary10.Person> list)
        {
            string  name;
            int age = 0, experience = 0;
            bool delete_ok = false;

            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя ");
          
            name = Convert.ToString(Console.ReadLine());
           
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }
            Console.WriteLine();
            delete_ok = list.Remove(new MyClassLibrary10.Employee { Name = name, Age = age, Experience = experience });
            if (delete_ok) Console.WriteLine("Элемент удалён");
            else Console.WriteLine("Элемент не найден");

        }
        #endregion

        //Имена всех лиц мужского (женского) пола.
       
        //Количество рабочих
        public static void CountOfWorkers(List<MyClassLibrary10.Person> list)
        {
            int count = 0;
            foreach (MyClassLibrary10.Person item in list)
            {
                if (item is MyClassLibrary10.Worker)
                    count++;
            }
            Console.WriteLine($"{count} рабочих");
        }
        //Количество инженеров заданной квалификации
        public static void CountOfEngeneer(List<MyClassLibrary10.Person> list)
        {
            int count = 0;
            Console.WriteLine("Введите квалификацию");
            string check = Console.ReadLine();
            foreach (MyClassLibrary10.Person item in list)
            {
                if (item is MyClassLibrary10.Engneer && (item as MyClassLibrary10.Engneer).Qualification == check)
                    count++;
            }
            Console.WriteLine($"{count}  {check} квалификации");
        }
        //Имена служащих с заданным стажем 
        public static void CountOfEmployees(List<MyClassLibrary10.Person> list)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.WriteLine("Введите стаж");
                    int check = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Служащие со стажем не меньше {check}");
                    foreach (MyClassLibrary10.Person item in list)
                    {
                        if (item is MyClassLibrary10.Employee && (item as MyClassLibrary10.Employee).Experience >= check)
                            Console.WriteLine($" {item.Name}");
                    }
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите целое неотрицательное число");
                }
            }
        }
        static void Print(List<MyClassLibrary10.Person> list)
        {
            foreach (var item in list)
            {
                (item as MyClassLibrary10.Person).PrintInfo();
                Console.WriteLine();
            }
        }
        #region добавить dictionary
        static void Add(ref Dictionary<int, MyClassLibrary10.Person> list)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Выбирите тип нового элемента:\n 1- Служащий; 2- Рабочий; 3- Инженер; 0- Выход в меню");
                bool vvod_ok = false;
                while (!vvod_ok)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0) return;
                        if (choice == 1)
                        {
                            MakeEmployee(ref list);
                            vvod_ok = true;
                        }
                        if (choice == 2)
                        {
                            MakeWorker(ref list);
                            vvod_ok = true;
                        }
                        if (choice == 3)
                        {
                            MakeEngineer(ref list);
                            vvod_ok = true; Console.WriteLine("Выбирите тип нового элемента:\n 1- Служащий; 2- Рабочий; 3- Инженер; 0- Выход в меню");
                        }
                        if (choice != 1 && choice != 2 && choice != 3 && choice != 0)
                        {
                            Console.WriteLine("Введите число из  предложенных");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите целое положительное число из предложенных");
                    }
                }
            }
        }

        static void MakeEmployee(ref Dictionary<int, MyClassLibrary10.Person> list)
        {
            string name;
            int age = 0, experience = 0;
            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя ");
            
            name = Convert.ToString(Console.ReadLine());
           
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }

            list.Add(list.Count + 1, new MyClassLibrary10.Employee() { Name = name, Age = age, Experience = experience });
            Console.WriteLine("Элемент добавлен");
        }
        static void MakeWorker(ref Dictionary<int, MyClassLibrary10.Person> list)
        {
            string name,  workplace;
            int age = 0, experience = 0;
            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя ");
           
            name = Convert.ToString(Console.ReadLine());
           
            Console.WriteLine("Место работы ");
            workplace = Convert.ToString(Console.ReadLine());
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }

            list.Add(list.Count + 1, new MyClassLibrary10.Worker() { Name = name,  Age = age, Experience = experience, WorkPlace = workplace });
            Console.WriteLine("Элемент добавлен");
        }
        static void MakeEngineer(ref Dictionary<int, MyClassLibrary10.Person> list)
        {
            string name, surname, patronamic, sex, qualification;
            int age = 0, experience = 0;
            bool vvod_ok = false;

            Console.WriteLine("Введите:");
            Console.WriteLine("Фамилию Имя ");
            
            name = Convert.ToString(Console.ReadLine());
           
            Console.WriteLine("Квалификация ");
            qualification = Convert.ToString(Console.ReadLine());
            while (!vvod_ok)
            {
                try
                {
                    Console.WriteLine("Возраст ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж работы ");
                    experience = Convert.ToInt32(Console.ReadLine());
                    vvod_ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод числовых данных! Попробуйте еще раз.");
                }
            }

            list.Add(list.Count + 1, new MyClassLibrary10.Engneer() {  Name = name, Age = age, Experience = experience, Qualification = qualification });
            Console.WriteLine("Элемент добавлен");
        }
        #endregion
        #region удалить dictionary
        static void Delete(ref Dictionary<int, MyClassLibrary10.Person> list)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1- Удалить по номеру; 0- Выход в меню");
                bool vvod_ok = false;
                while (!vvod_ok)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 0) return;
                        if (choice == 1)
                        {
                            DeleteOnNumber(ref list);
                            vvod_ok = true;
                        }
                        if (choice != 1 && choice != 2 && choice != 3 && choice != 0)
                        {
                            Console.WriteLine("Введите число из  предложенных");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите целое положительное число из предложенных");
                    }
                }
            }
        }
        static void DeleteOnNumber(ref Dictionary<int, MyClassLibrary10.Person> list)
        {
            int i = 1, number = 0;
            bool vvod_ok = false;
            foreach (MyClassLibrary10.Person item in list.Values)
            {
                Console.WriteLine(i);
                item.PrintInfo();
                Console.WriteLine();
                i++;
            }

            Console.WriteLine("Выбирите номер для удаления: ");
            while (!vvod_ok)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > list.Count)
                    {
                        Console.WriteLine("Номер превысил границы списка");
                    }
                    else
                    {
                        vvod_ok = true;
                        list.Remove(number);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите целое положительное число");
                }
            }
            Console.WriteLine("Список после удаления элемента: ");
            i = 1;
            foreach (MyClassLibrary10.Person item in list.Values)
            {
                Console.WriteLine(i);
                item.PrintInfo();
                Console.WriteLine();
                i++;
            }
        }
        #endregion
        //Имена всех лиц мужского (женского) пола.
       
        //Количество рабочих
        public static void CountOfWorkers(Dictionary<int, MyClassLibrary10.Person> list)
        {
            int count = 0;
            foreach (MyClassLibrary10.Person item in list.Values)
            {
                if (item is MyClassLibrary10.Worker)
                    count++;
            }
            Console.WriteLine($"{count} рабочих");
        }
        //Количество инженеров заданной квалификации
        public static void CountOfEngeneer(Dictionary<int, MyClassLibrary10.Person> list)
        {
            int count = 0;
            Console.WriteLine("Введите квалификацию");
            string check = Console.ReadLine();
            foreach (MyClassLibrary10.Person item in list.Values)
            {
                if (item is MyClassLibrary10.Engneer && (item as MyClassLibrary10.Engneer).Qualification == check)
                    count++;
            }
            Console.WriteLine($"{count}  {check} квалификации");
        }
        //Имена служащих с заданным стажем 
        public static void CountOfEmployees(Dictionary<int, MyClassLibrary10.Person> list)
        {
            bool ok = false;
            while (!ok)
            {
                try
                {
                    Console.WriteLine("Введите стаж");
                    int check = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Служащие со стажем не меньше {check}");
                    foreach (MyClassLibrary10.Person item in list.Values)
                    {
                        if (item is MyClassLibrary10.Employee && (item as MyClassLibrary10.Employee).Experience >= check)
                            Console.WriteLine($" {item.Name}");
                    }
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите целое неотрицательное число");
                }
            }
        }
        static void Print(Dictionary<int, MyClassLibrary10.Person> list)
        {

            foreach (KeyValuePair<int, MyClassLibrary10.Person> keyValue in list)
            {
                bool check = false;
                if (keyValue.Value is MyClassLibrary10.Worker)
                {
                    Console.WriteLine($"{keyValue.Key}  {(keyValue.Value as MyClassLibrary10.Worker).Name} {(keyValue.Value as MyClassLibrary10.Worker).Age}  {(keyValue.Value as MyClassLibrary10.Worker).Experience}  {(keyValue.Value as MyClassLibrary10.Worker).WorkPlace} ");
                    check = true;
                }
                if (keyValue.Value is MyClassLibrary10.Engneer)
                {
                    Console.WriteLine($"{keyValue.Key} {(keyValue.Value as MyClassLibrary10.Engneer).Name} {(keyValue.Value as MyClassLibrary10.Engneer).Age}  {(keyValue.Value as MyClassLibrary10.Engneer).Experience}  {(keyValue.Value as MyClassLibrary10.Engneer).Qualification}");
                    check = true;
                }
                if (keyValue.Value is MyClassLibrary10.Employee && !check)
                    Console.WriteLine($"{keyValue.Key}  {(keyValue.Value as MyClassLibrary10.Employee).Name} {(keyValue.Value as MyClassLibrary10.Employee).Age}  {(keyValue.Value as MyClassLibrary10.Employee).Experience}");

            }
        }
        static void Part1()
        {
            List<MyClassLibrary10.Person> list = new List<MyClassLibrary10.Person>(1);

            list.Add(new MyClassLibrary10.Employee() { Name = "Григорий", Age = 35, Experience = 12 });
            list.Add(new MyClassLibrary10.Employee() {  Name = "Нина", Age = 46, Experience = 25 });
            list.Add(new MyClassLibrary10.Worker() { Name = "Лариса",  Age = 21, Experience = 1, WorkPlace = "ОАО Мотовилихинские заводы" });
            list.Add(new MyClassLibrary10.Worker() { Name = "Никита", Age = 20, Experience = 2, WorkPlace = "КамКабель" });
            list.Add(new MyClassLibrary10.Engneer() {  Name = "Евгений", Age = 31, Experience = 8, Qualification = "вторая" });
            list.Add(new MyClassLibrary10.Engneer() { Name = "Святослав", Age = 53, Experience = 30, Qualification = "высшая" });

            Console.WriteLine("Список создан");

            Menu(ref list);

            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Выбирите запрос:");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("2.Количество объектов класса Worker ");
            Console.WriteLine("3.Количество инженеров с заданной квалификацией");
            Console.WriteLine("4.Имена служащих со стажем не менее заданного");

            Console.WriteLine("Введите номер запроса или \"exit\" для перехода к следующим действиям");
            string s1 = "";

            try
            {
                s1 = Console.ReadLine();
                while (s1 != "exit")
                {
                    int number = Convert.ToInt32(s1);
                    
                    if (number == 2)
                        CountOfWorkers(list);
                    if (number == 3)
                        CountOfEngeneer(list);
                    if (number == 4)
                        CountOfEmployees(list);

                    Console.WriteLine("Введите номер запроса или \"exit\" для перехода к следующим действиям");
                    s1 = Console.ReadLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Номер введен неверно");
            }

            Console.WriteLine("\nДемонстрация клонирования");
            Console.ForegroundColor = ConsoleColor.White;

            MyClassLibrary10.Employee obj = new MyClassLibrary10.Employee("Паластрова Нина Васильевна", 46, 25);

            MyClassLibrary10.Employee copy = (MyClassLibrary10.Employee)obj.Clone();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Результат клонирования:");
            Console.ForegroundColor = ConsoleColor.White;
            copy.PrintInfo();

            Console.WriteLine("Сортировка по стажу");
            Console.WriteLine("До сортировки");
            Print(list);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ");
            Console.ForegroundColor = ConsoleColor.White;

            list.Sort();
            Print(list);

            Console.WriteLine("Поиск элемента");
            MyClassLibrary10.Engneer findEng = new MyClassLibrary10.Engneer("Катаев Евгений", 31, 8, "вторая");
            int index = -1;
            index = list.BinarySearch(findEng);

            findEng.PrintInfo();
            if (index == -1)
                Console.WriteLine("Элемент не найден");
            else
                Console.WriteLine($"Элемент найден на позиции {index}");
        }
        static void Part2()
        {
            Dictionary<int, MyClassLibrary10.Person> collection = new Dictionary<int, MyClassLibrary10.Person>(1);

            do
            {
                Console.WriteLine("1.Создать");
                Console.WriteLine("2.Добавить элемент в конец");
                Console.WriteLine("3.Удалить элемент");
                Console.WriteLine("4.Вывод на экран");
                Console.WriteLine("5.Количество рабочих");
                Console.WriteLine("6.Количество инженеров заданной квалификации");
                Console.WriteLine("7.Клонирование");
                Console.WriteLine("8.Поиск");
                Console.WriteLine("0.Назад");

                int oper = int.Parse(Console.ReadLine());
                if (oper == 0)
                    break;

                switch (oper)
                {
                    case 1:
                        {
                            Console.WriteLine("Словарь из 6 элементов создан\n");
                            collection.Add(1, new MyClassLibrary10.Employee() { Name = "Григорий Першин", Age = 35, Experience = 12 });
                            collection.Add(2, new MyClassLibrary10.Employee() { Name="Паластрова Нина",  Age = 46, Experience = 25 });
                            collection.Add(3, new MyClassLibrary10.Worker() { Name = "Лазарева Лариса", Age = 21, Experience = 1, WorkPlace = "ОАО Мотовилихинские заводы" });
                            collection.Add(4, new MyClassLibrary10.Worker() { Name = "Шаклеин Никита", Age = 20, Experience = 2, WorkPlace = "КамКабель" });
                            collection.Add(5, new MyClassLibrary10.Engneer() { Name = "Катаев Евгений", Age = 31, Experience = 8, Qualification = "вторая" });
                            collection.Add(6, new MyClassLibrary10.Engneer() { Name = "Поляков Cвятослав", Age = 53, Experience = 30, Qualification = "высшая" });
                            break;
                        }
                    case 2:
                        {
                            Add(ref collection);
                            break;
                        }
                    case 3:
                        {
                            if (collection.Count > 0)
                            {
                                Delete(ref collection);
                            }
                            else
                                Console.WriteLine("Словарь пуст");
                            break;
                        }
                    case 4:
                        {
                            Print(collection);
                            break;
                        }
                    
                    case 5:
                        {
                            CountOfWorkers(collection);
                            break;
                        }
                    case 6:
                        {
                            CountOfEngeneer(collection);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\nДемонстрация клонирования");
                            Console.ForegroundColor = ConsoleColor.White;

                            MyClassLibrary10.Employee obj = new MyClassLibrary10.Employee("Паластрова Нина", 46, 25);

                            MyClassLibrary10.Employee copy = (MyClassLibrary10.Employee)obj.Clone();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Результат клонирования:");
                            Console.ForegroundColor = ConsoleColor.White;
                            copy.PrintInfo();

                            break;
                        }
                    case 8:
                        {
                            bool index = true;
                            MyClassLibrary10.Engneer findEng = new MyClassLibrary10.Engneer("Катаев Евгений", 31, 8, "вторая");
                            Console.WriteLine("Введите номер элемента");

                            index = collection.ContainsValue(findEng);
                            if (!index)
                                Console.WriteLine("Элемент не найден");
                            else
                                Console.WriteLine($"Элемент найден");
                            break;
                        }
                    default:
                        break;
                }
            }
            while (true);
        }
        static void Part3()
        {
            TestCollections task=new TestCollections(0);
            do
            {
                Console.WriteLine("1.Создать коллекции");
                Console.WriteLine("2.Печать");
                Console.WriteLine("3.Поиск");
                Console.WriteLine("4.Добавить элемент");
                Console.WriteLine("5.Удалить элемент");
                Console.WriteLine("0.Назад");

                int oper = int.Parse(Console.ReadLine());
                if (oper == 0)
                    break;

                switch (oper)
                {
                    case 1:
                        {
                            Console.WriteLine("Для создания коллекций введите их длину");
                            int count = Convert.ToInt32(Console.ReadLine());
                            task = new TestCollections(count);
                            Console.WriteLine("Коллекции созданы");
                            break;
                        }
                    case 2:
                        {
                            task.Print();
                            break;
                        }
                    case 3:
                        {
                            task.Search();

                            break;
                        }
                    case 4:
                        {
                            task.Add();
                            break;
                        }
                    case 5:
                        {
                            task.Delete();
                            break;
                        }
                }
            } while (true);
           
        }
    static void Main(string[] args)
        { 
        //    Part1();

        //    Part2();

            Part3();

            Console.ReadKey();
        }
    }
}
