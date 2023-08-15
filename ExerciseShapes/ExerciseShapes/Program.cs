using ExerciseShapes.Entities;
using ExerciseShapes.Entities.Enums;
using System;

namespace ExerciseShapes
{
    internal class Program {
        static void Main(string[] args) {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int qtdShapes = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qtdShapes; i++) {
                Console.WriteLine($"\nShape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (BLACK/BLUE/RED): ");
                Colors color = Enum.Parse<Colors>(Console.ReadLine());

                if(ch == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(color,width, height));
                }
                else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("\n\nSHAPE AREAS:");
            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}