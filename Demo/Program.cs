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
        }
    }
}
