
using System.Threading.Channels;
using Task23._1.Moduls;

namespace Task23._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person samir = new Person("Samir","Karimov",21);
            Person emil = new Person("Emil","Pasayev",19);
            Person garip = new Person("Garip","Garibzade",20);
            Person gariba = new Person("Gariba","Garibova",20);
            List<Person> people = new List<Person>();
            people.Add(samir);
            people.Add(emil);
            people.Add(garip);
            people.Add(gariba);
            Console.WriteLine(" Adı Kamil(her hansisa bir ad) olan person-u çıxarsın.");
            people.FindAll(s => s.Name.ToLower() == "samir")
                .ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
            //people.FindAll(s => s.Surname.ToLower() == "pasayev")
            //    .ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
            Console.WriteLine(" ");            
            Console.WriteLine("Yaşı 20+ olanları çıxarsın");
            people.FindAll(s => s.Age >= 20)
                .ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));
            Console.WriteLine(" ");
            Console.WriteLine("Soyadı ov ve ova ilə bitən tələbələri çıxarsın.");
            people.FindAll(s => s.Surname.ToLower().Contains("ov") || s.Surname.ToLower().Contains("ova"))
                .ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Age));


            //---------222222222----------

            List<Exam> exams = new List<Exam>();
            Exam aztu = new Exam("Aztu Exam",125,DateTime.Now);
            Exam devalopia = new Exam("Devalopia Exam",90,DateTime.Now);
            Exam code = new Exam("Code Academy Exam",150,DateTime.Now);

            exams.Add(aztu);
            exams.Add(devalopia);
            exams.Add(code);
            aztu.Start();
            Console.WriteLine("");


            Console.WriteLine(" son 1 hefdede  olan exam");
            exams.FindAll(s => s.StartDate <= s.StartDate.AddDays(7))
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            Console.WriteLine(" ");
            Console.WriteLine("2 saatdan chox olan exam ");
            exams.FindAll(s => s.ExamDuration > 120)
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            Console.WriteLine(" ");
            Console.WriteLine("hazirda davam eden exam ");
            exams.FindAll(s => DateTime.Now >=s.StartDate && DateTime.Now < s.EndDate)
                .ForEach(s => Console.WriteLine(s.Subject + " " + s.ExamDuration));
            Console.WriteLine(" ");

        }
    }
}
