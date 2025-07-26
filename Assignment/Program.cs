namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            //for (int i = 0; i <= (int)WeekDays.Sunday; i++)
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}

            #endregion
            #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Please Enter The Required Season Name from Below Options: -");
            //Console.WriteLine("1 - Spring");
            //Console.WriteLine("2 - Summer");
            //Console.WriteLine("3 - Autumn");
            //Console.WriteLine("4 - Winter");

            //Console.Write("Season Name is: ");
            //string input = Console.ReadLine();

            //Console.Clear();
            //if (Enum.TryParse(typeof(SeasOn), input,true, out object? result))
            //{
            //    SeasOn season = (SeasOn)result;

            //    switch (season)
            //    {
            //        case SeasOn.Spring:
            //            Console.WriteLine("Spring is from March to May.");
            //            break;
            //        case SeasOn.Summer:
            //            Console.WriteLine("Summer is from June to August.");
            //            break;
            //        case SeasOn.Autumn:
            //            Console.WriteLine("Autumn is from September to November.");
            //            break;
            //        case SeasOn.Winter:
            //            Console.WriteLine("Winter is from December to February.");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Invalid season entered.");



            #endregion
            #region 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable

            //Permissions perm = Permissions.None;

            //perm |= Permissions.Read;
            //perm |= Permissions.Write;
            //perm |= Permissions.Execute;
            //perm |= Permissions.Delete;

            //Console.WriteLine($"Permessions Now are : {perm}");

            //if ((perm & Permissions.Write) == Permissions.Write)
            //    Console.WriteLine("Permession Write is set");

            //perm &= ~Permissions.Write;
            //Console.WriteLine("After removing Write: " + perm);

            //if ((perm & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission still exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Write permission has been removed.");
            //}

            #endregion
            #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Please Enter The Required Color : -");

            //Console.Write("Color Name is: ");
            //string input = Console.ReadLine();

            //Console.Clear();
            //if (Enum.TryParse(typeof(Colors), input, true, out object? result))
            //{
            //    Colors color = (Colors)result;

            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:  
            //        case Colors.Blue:
            //            Console.WriteLine("Color is Primary");
            //            break;
            //        default:
            //            Console.WriteLine("Color is not Primary.");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Please Enter Valid Color");

            #endregion
            Console.WriteLine("New code from assignment branch");
        }
    }
}
