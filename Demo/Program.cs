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



            #endregion
        }
    }
}
