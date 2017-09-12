using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Введите количество сотрудников: ");
            string sizeAsString = Console.ReadLine();
            bool result = Int32.TryParse(sizeAsString, out size);
            if (!result)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   sizeAsString == null ? "<null>" : sizeAsString);
            }

            Employee[] employees = new Employee[size];

            for(int i = 0; i < size; i++)
            {
                Console.Clear();
                employees[i].Id = i + 1;

                Console.WriteLine("Введите ФИО сотрудника {0}:", employees[i].Id);
                employees[i].FullName = Console.ReadLine();

                Console.WriteLine("Введите должность сотрудника {0}:", employees[i].Id);
                Console.WriteLine("1 - Босс\n2 - Менеджер\n3 - Клерк");
                int numPos;
                string numPosAsString = Console.ReadLine();
                bool res = Int32.TryParse(numPosAsString, out numPos);
                if (!res)
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       numPosAsString == null ? "<null>" : numPosAsString);
                }
                if (numPos == 1) { employees[i].Pos = Position.Boss; }
                else if (numPos == 2) { employees[i].Pos = Position.Manager; }
                else if (numPos == 3) { employees[i].Pos = Position.Clerk; }

                Console.WriteLine("Введите зарплату сотрудника {0}: ", employees[i].Id);
                double salary;
                string salaryAsString = Console.ReadLine();
                bool resTwo = Double.TryParse(salaryAsString, out salary);
                if (!res)
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       salaryAsString == null ? "<null>" : salaryAsString);
                }

                Console.WriteLine("Введите дату принятия на работу сотрудника {0} (дд.мм.гггг): ", employees[i].Id);
                employees[i].HiringDate = DateTime.Parse(Console.ReadLine());
            }


        }
    }
}
