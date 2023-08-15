using ExerciseShapes.Entities.Enums;


namespace ExerciseShapes.Entities {
    internal class Rectangle: Shape {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }
        public Rectangle(Colors color ,double width, double height)
        : base(color) 
        {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}
