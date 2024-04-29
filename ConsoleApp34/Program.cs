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

            basla:
            Console.WriteLine("Daxil etmek istediyiniz exam sayini yazin :");
            int girilendeyer;
            if (!int.TryParse(Console.ReadLine(), out girilendeyer))
            {
                Console.WriteLine("Dogru deyer daxil edin");
                goto basla; 
            }



            for (int i = 0; i < girilendeyer; i++)
            {
                Exam exam1 = new Exam();

                start: 

                Console.Write("Studenti daxil edin: ");
                exam1.Student = Console.ReadLine();

                Console.Write("Bal  daxil edin:");
                string pointInput = Console.ReadLine();
                int point;
                if (!int.TryParse(pointInput, out point))
                {
                    Console.WriteLine("Bali doğru daxil edin :");
                    goto start; 
                }
                exam1.Point = point;

                Console.Write("Imtahan adini daxil edin:");
                exam1.Subject = Console.ReadLine();

                Console.Write("Baslangic vaxti  daxil edin:");
                DateTime startDate;
                if (!DateTime.TryParse(Console.ReadLine(), out startDate))
                {
                    Console.WriteLine("Baslama vaxtini dogru daxil edin :");
                    goto start; 
                }
                exam1.StartDate = startDate;

                Console.Write("Cixis vaxtini daxil edin :");
                DateTime endDate;
                if (!DateTime.TryParse(Console.ReadLine(), out endDate))
                {
                    Console.WriteLine("Bitis vaxtini doğru daxil edin :");
                    goto start; 
                }
                exam1.EndDate = endDate;

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

