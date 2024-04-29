using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> examlist = new List<Exam>();


            Console.WriteLine("Daxil etmet istediyiniz exam sayini yazin");
            int girilendeyer = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < girilendeyer; i++)
            {
                Exam exam1 = new Exam();

                Console.Write("Studenti daxil edin: ");
                exam1.Student = Console.ReadLine();


                Console.Write("Bal  daxil edin:");
                exam1.Point = int.Parse(Console.ReadLine());

                Console.Write("Imtahan adini daxil edin:");
                exam1.Subject = (Console.ReadLine());

                Console.Write("Baslangic vaxti  daxil edin:");
                exam1.StartDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Cixis vaxtini daxil edin:");
                exam1.EndDate = DateTime.Parse(Console.ReadLine());

                examlist.Add(exam1);

            }

            foreach (var exam1 in examlist)
            {
                if (exam1.Point > 50)
                {
                    Console.WriteLine($"{exam1.Student} {exam1.Subject} {exam1.Point}");
                }
            }

            foreach (var exam1 in examlist)
            {
                if (exam1.EndDate - exam1.StartDate > new TimeSpan(1, 0, 0))
                {
                    Console.WriteLine($"{exam1.Student} {exam1.Subject} {exam1.StartDate} {exam1.EndDate}");
                }
            }

        }
    }
}

