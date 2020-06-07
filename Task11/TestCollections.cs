using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task11
{
    class TestCollections
    {
        List<Person> list1;
        List<string> list2;
        Dictionary<Person, Worker> dict1;
        Dictionary<string, Worker> dict2;
        Worker first = null;
        Worker middle = null;
        Worker end = null;
        Worker outt = null;

        public TestCollections(int count)
        {
            list1 = new List<Person>(1);
            list2 = new List<string>(1);
            dict1 = new Dictionary<Person, Worker>(1);
            dict2 = new Dictionary<string, Worker>(1);


            for (int i = 0; i < count; i++)
            {
                Worker work = new Worker();
                list1.Add(work.GetBasePerson());
                dict1.Add(work.GetBasePerson(), work);

                list2.Add(work.GetBasePerson().ToString());
                dict2.Add(work.GetBasePerson().ToString(), work);

                if (i == 0)
                    first = (Worker)work.Clone();
                if (i == count / 2)
                    middle = (Worker)work.Clone();
                if (i == count - 1)
                    end = (Worker)work.Clone();
            }
            Worker outt2 = new Worker("Инокентий Дроздов", 25, 4, "КамКабель");
            outt = (Worker)outt2.Clone();
        }
        public void Print()
        {
            Console.WriteLine("Коллекция 1 List<Person>");
            foreach (Person item in list1)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Коллекция 1 List<string>");
            foreach (string item in list2)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine("Коллекция 2 Dictionary<Person, Work>");
            foreach (KeyValuePair<Person, Worker> keyValue in dict1)
            {

                Console.WriteLine($"Ключ: {keyValue.Key.Name} {keyValue.Key.Age} Значение: {keyValue.Value.Name} {keyValue.Value.Age} место работы: {keyValue.Value.WorkPlace} стаж: {keyValue.Value.Experience} ");
            }

            Console.WriteLine(" Коллекция 2 Dictionary<string, Work>");
            foreach (KeyValuePair<string, Worker> keyValue in dict2)
            {

                Console.WriteLine($"Ключ: {keyValue.Key} Значение: {keyValue.Value.Name} {keyValue.Value.Age} место работы: {keyValue.Value.WorkPlace} стаж: {keyValue.Value.Experience} ");
            }

        }
        public void Search()
        {
            #region поиск в списке
            Console.WriteLine("Поиск в списках");
            //первый элемент
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск первого элемента:");
            Console.ForegroundColor = ConsoleColor.White;

            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (list1.Contains(first.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(first.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed} ");
            }
            else Console.WriteLine("Элемент не найден");
            sw.Reset();

            sw.Start();
            if (list2.Contains(first.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(first.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            //серидинный элемент
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск среднего элемента:");
            Console.ForegroundColor = ConsoleColor.White;

            sw.Reset();
            sw.Start();
            if (list1.Contains(middle.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(middle.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed} ");
            }
            else Console.WriteLine("Элемент не найден");

            sw.Restart();

            if (list2.Contains(middle.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(middle.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            //последний элемент
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск последнего элемента:");
            Console.ForegroundColor = ConsoleColor.White;

            sw.Reset();
            sw.Start();
            if (list1.Contains(end.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(end.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed} ");
            }
            else Console.WriteLine("Элемент не найден");

            sw.Restart();

            if (list2.Contains(end.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(end.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            //несуществующий элемент
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск невходящего элемента:");
            Console.ForegroundColor = ConsoleColor.White;

            sw.Reset();
            sw.Start();
            if (list1.Contains(outt.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(outt.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed} ");
            }
            else
            {
                sw.Stop();
                Console.WriteLine($"Элемент не найден за {sw.Elapsed}");
            }

            sw.Reset();
            sw.Start();
            if (list2.Contains(outt.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(outt.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else
            {
                sw.Stop();
                Console.WriteLine($"Элемент не найден за {sw.Elapsed}");
            }

            Console.WriteLine("\nПоиск в словарях по ключу");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск первого элемента:");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
            #region поиск в словаре
            //первый элемент
            sw.Reset();
            sw.Start();
            if (dict1.ContainsValue(first))
            {
                sw.Stop();
                Console.WriteLine(first.ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else Console.WriteLine("Элемент не найден");
            sw.Reset();
            sw.Start();
            if (dict2.ContainsKey(first.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(first.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else Console.WriteLine("Элемент не найден");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск серединного элемента:");
            Console.ForegroundColor = ConsoleColor.White;

            //серединный элемент
            sw.Reset();
            sw.Start();
            if (dict1.ContainsKey(middle.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(middle.ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else Console.WriteLine("Элемент не найден");
            sw.Reset();
            sw.Start();
            if (dict2.ContainsKey(middle.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(middle.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else Console.WriteLine("Элемент не найден");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск последнего элемента:");
            Console.ForegroundColor = ConsoleColor.White;
            //последний элемент
            sw.Reset();
            sw.Start();
            if (dict1.ContainsKey(end.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(end.ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else Console.WriteLine("Элемент не найден");
            sw.Reset();
            sw.Start();
            if (dict2.ContainsKey(end.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(end.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else Console.WriteLine("Элемент не найден");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Поиск последнего элемента:");
            Console.ForegroundColor = ConsoleColor.White;
            //левый элемент
            sw.Reset();
            sw.Start();
            if (dict1.ContainsKey(outt.GetBasePerson()))
            {
                sw.Stop();
                Console.WriteLine(outt.ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else
            {
                sw.Stop();
                Console.WriteLine($"Элемент не найден за {sw.Elapsed}");
            }

            sw.Reset();
            sw.Start();
            if (dict2.ContainsKey(outt.GetBasePerson().ToString()))
            {
                sw.Stop();
                Console.WriteLine(outt.GetBasePerson().ToString());
                Console.WriteLine($"Элемент найден за {sw.Elapsed}");
            }
            else
            {
                sw.Stop();
                Console.WriteLine($"Элемент не найден за {sw.Elapsed}");
            }

        }
        #endregion
        public void Add()
        {
            Worker element;
            string name, workplace;
            int age = 0, exp = 0;
            do
            {
                Console.WriteLine("Введите данные");
                Console.WriteLine("Фамилия Имя: ");
                name = Console.ReadLine();
                Console.WriteLine("Место работы: ");
                workplace = Console.ReadLine();
                try
                {
                    Console.WriteLine("Возраст: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Стаж: ");
                    exp = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Числовые значения введены не корректно. Введите заного");
                }

                element = new Worker(name, age, exp, workplace);
            } while (dict1.ContainsKey(element.GetBasePerson()));

            list1.Add(element.GetBasePerson());
            list2.Add(element.GetBasePerson().ToString());
            dict1.Add(element.GetBasePerson(), element);
            dict2.Add(element.GetBasePerson().ToString(), element);
            Console.WriteLine("Элемент добавлен");
        }
        public void Delete()
        {
            Worker element;
            string name, workplace;
            int age = 0, exp = 0;

            Console.WriteLine("Введите данные");
            Console.WriteLine("Фамилия Имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Место работы: ");
            workplace = Console.ReadLine();
            try
            {
                Console.WriteLine("Возраст: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Стаж: ");
                exp = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Числовые значения введены не корректно. Введите заного");
            }

            element = new Worker(name, age, exp, workplace);

            if (list1.Contains(element.GetBasePerson()))
            {
                list1.Remove(element.GetBasePerson());
                list2.Remove(element.GetBasePerson().ToString());

                dict1.Remove(element.GetBasePerson());
                dict2.Remove(element.GetBasePerson().ToString());
                Console.WriteLine("Элемент удален");
            }
            else Console.WriteLine("Элемент не найден");
        }
    }
}
