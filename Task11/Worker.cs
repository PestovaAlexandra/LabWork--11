using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Worker:Person
    {
        static string[] Factors = { "КамКабель", "БИО Мед", "Завод ГСК", "Лесозавод", "КамГЭС", "Пороховой завод", "НПО Искра", "БумКомбинат", "ПНОС", "ОАО Мотавилихинские заводы" };
        public int Experience { get; set; }
        public string WorkPlace { get; set; }
        static string MakeWork()
        {
            return Factors[rnd.Next(Factors.Length)];
        }
        public Worker() : base()
        {
            Experience = rnd.Next(1, 1000);
            WorkPlace = MakeWork();
        }
        public Worker(string name, int age, int exp, string work) : base(name, age)
        {
            Experience = exp;
            WorkPlace = work;
        }
        public override string ToString()
        {
            return base.ToString() + " место работы: " + WorkPlace + " стаж: " + Experience;
        }
        public Person GetBasePerson()
        {
            return new Person(this.Name, this.Age);
        }
        new public object Clone()
        {
            return new Worker(this.Name, this.Age, this.Experience, this.WorkPlace);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && (this.Experience == ((Worker)obj).Experience) && (this.WorkPlace == ((Worker)obj).WorkPlace);

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" место работы: {WorkPlace} стаж: {Experience}\n");

        }
    }
}
