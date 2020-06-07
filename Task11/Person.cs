using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Person : ICloneable
    {
        protected static Random rnd = new Random();
        static string[] NameMale = { "Иван", "Пётр", "Максим", "Андрей", "Сергей", "Данил", "Григорий", "Алексей", "Артём", "Евгений" };
        static string[] SurnameMale = { "Сидоров", "Петров", "Иванов", "Фёдоровых", "Постнов", "Осипов", "Корзников", "Бутин", "Утробин", "Байбурин" };
        static string[] NameFemale = { "Жанна", "Светлана", "Елена", "Ольга", "Анжелика", "Юлия", "Анна", "Анастасия", "Ирина", "Александра" };
        static string[] SurnameFemale = { "Аристова", "Горожанина", "Мазилова", "Бахарева", "Кувыркина", "Пильгун", "Мальцева", "Попова", "Шапикаева", "Ионникова" };



        public string Name { get; set; }
        public int Age { get; set; }

        static string MakeName()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return NameFemale[rnd.Next(NameFemale.Length)] + SurnameFemale[rnd.Next(SurnameFemale.Length)];
            }
            else
                return NameMale[rnd.Next(NameMale.Length)] + SurnameMale[rnd.Next(SurnameMale.Length)];
        }
        public Person()
        {
            Name = MakeName();
            Age = rnd.Next(1, 1000);
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name.ToString() + " " + Age.ToString();
        }
        public object Clone()
        {
            return new Person(this.Name, this.Age);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            return (this.Name == p.Name) && (this.Age == p.Age);

        }
        public virtual void Print()
        {
            Console.WriteLine($"{Name} {Age}");
        }
    }
}
