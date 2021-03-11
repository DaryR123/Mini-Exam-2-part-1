using System;

class MainClass {
  public static void Main (string[] args) {
   

}
public static double CylinderVolume(double volume)
{
   double radius;
   double height;
   double pie = 3.14;
   double volume;
  
  Console.WriteLine("Enter the radius of cylinder");
   radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height of cylinder");
   height = Convert.ToDouble(Console.ReadLine());


  double volume = pie * ( radius*radius) * height;  
Console.WriteLine(" The volume of the cylinder is " + volume);

 
  }
}