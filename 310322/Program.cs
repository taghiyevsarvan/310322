using System;

namespace _310322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TaskAbout
            /*
             
             */
            #endregion
            Console.WriteLine("Telebenin elave edileceyi grupu secin:");
            Console.WriteLine("1-Programming\n2-Desigin\n3-System");
            GroupType type = new GroupType();
            Group group = new Group(type)
            {
                Type = type,
            };
            Console.WriteLine("Nece eded telebe elave edeceksiniz ?");
            int student_value = int.Parse(Console.ReadLine());
            for (int i = 0; i < student_value; i++)
            {
                Console.WriteLine("Telebe Adi, Soyadi");
                string fullName = Console.ReadLine();
                Student student = new Student()
                {
                    FullName = fullName,
                };
                group.AddStudent(student);
            }
            Console.WriteLine("1.GetStudentByNo\n2.Quit");
            int choise = int.Parse(Console.ReadLine());
            bool quit = true;
            do
            {
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Axtarilacaq No daxil edin: ");
                        int studentNo = int.Parse(Console.ReadLine()) ;
                        Console.WriteLine(group.GetStudentByNo(studentNo));
                        Console.WriteLine("Grup nomresi " + group.No);
                        break;
                    case 2:
                        quit = false;
                        break;
                    default:
                        break;
                }
            } while (quit);

        }
    }
}
