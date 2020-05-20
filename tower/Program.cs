using System;
using tower;

namespace TreehouseDefense
{
    class Program
    {
        public static void Main()
        {
    
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}
