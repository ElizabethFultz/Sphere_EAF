using System;

namespace Sphere_EAF
{
    class Application
    {
        static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere();
            Console.WriteLine("sphere1: " + sphere1.ToString());

            Sphere sphere2 = new Sphere(5.2);
            Console.WriteLine("The diameter of sphere2 is: " + sphere2.GetDiameter() + "\nThe volume of sphere2 is: " + 
                sphere2.GetVolume() + "\nThe surface area of sphere2 is: " + sphere2.GetSurfaceArea());

            Console.WriteLine("\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
