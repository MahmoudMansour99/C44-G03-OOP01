using Common;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Library

            //Product product = new Product();
            #endregion

            #region User Defined Data Type



            #endregion

            #region Access Modifier 
            TypeA typeA = new TypeA();
            //typeA.X = 10; // Invalid because it's private and in another project 

            //typeA.Y = 10; // Invalid because its internal and in another prohject

            //typeA.Z = 10; // Valid because it is public 

            #endregion

            #region Enums

            #region Example 01
            //Person person = new Person();

            //person.Id = 10;
            //person.Name = "Ahmed";
            ////person.Gender = "Hamada";
            //person.Gender = Gender.Male;

            //Grade G01 = Grade.A;
            //Grade G01 = Grade.B;

            //if (G01 == Grade.A)
            //    Console.WriteLine("Barvo!");
            //else
            //    Console.WriteLine(":(");

            //Grade G01 = (Grade)10;

            //Console.WriteLine(G01);

            //Grade G01 = new Grade();

            //Console.WriteLine(G01);

            #endregion

            #region Example 02

            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "Eman",
            //    Branch = Branch.Dokki,
            //    Gender = Gender.F,
            //    Grade = Grade.B,
            //};

            //Student student = new Student();
            //bool IsParse;
            //Console.WriteLine("Please Enter Student Data: - ");
            //int Id;
            
            //do
            //{
            //    Console.Write("Id: ");
            //    IsParse = int.TryParse(Console.ReadLine(), out Id);
            //}
            //while (!IsParse);

            //student.Id = Id; // Student Id

            //Console.Write("Name: ");
            //student.Name = Console.ReadLine(); // Student Name

            //object Gender;

            //do
            //{
            //    Console.Write("Gender: ");
            //    IsParse = Enum.TryParse(typeof(Gender) ,Console.ReadLine(), out Gender);
            //}
            //while (!IsParse || Gender == null);

            //student.Gender = (Gender)Gender;

            //Branch Branch;

            //do
            //{
            //    Console.Write("Branch: ");
            //    IsParse = Enum.TryParse<Branch>(Console.ReadLine(), out Branch);
            //}
            //while (!IsParse);

            //student.Branch = Branch;

            //Grade Grade;

            //do
            //{
            //    Console.Write("Grade: ");
            //    IsParse = Enum.TryParse(Console.ReadLine(), out Grade);
            //}
            //while (!IsParse);
            //student.Grade = Grade;

            //Console.Clear();
            //Console.WriteLine($"Hello {student.Name} Welcome to Route Academy\n Branch is {student.Branch} and your Grade is {student.Grade}");

            #endregion

            #region Example 03

            //User user01 = new User();

            //user01.Id = 10;

            ////user01.Permessions[0] = true; // Write
            ////user01.Permessions[0] = false; // Read
            ////user01.Permessions[0] = true; // Execute
            ////user01.Permessions[0] = false; // Delete

            //user01.Permissions = (Permissions)3;
            ////                        0 0 1 1   Delete & Execute    

            //user01.Permissions = user01.Permissions ^ Permissions.Read;
            //                           3          ^      4
            //                        0011          ^     0100          = 0111 => 4 + 2 + 1 = 7  

            //Console.WriteLine(user01.Permissions);

            ////user01.Permissions = user01.Permissions ^ Permissions.Read;
            ////                           7          ^      4
            ////                        0111          ^     0100          = 0011 => 2 + 1 = 3  

            ////Console.WriteLine(user01.Permissions);

            //user01.Permissions = user01.Permissions & Permissions.Read;
            ////                           3          ^      4
            ////                        0111          ^     0100          = 0011 => 2 + 1 = 3  

            //Console.WriteLine(user01.Permissions);

            //if ((user01.Permissions & Permissions.Execute) == Permissions.Execute)
            //    Console.WriteLine("User has execute Permessions");
            //else
            //    user01.Permissions = user01.Permissions ^ Permissions.Execute;

            //user01.Permissions |= Permissions.Read;

            //if ((user01.Permissions | Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("User has Read Permessions");
            //else
            //    user01.Permissions = user01.Permissions ^ Permissions.Read;

            //Console.WriteLine(user01.Permissions);


            #endregion

            #endregion
        }
    }
}
