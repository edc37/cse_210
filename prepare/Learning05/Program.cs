using System;
namespace Shape{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create a list of Employees
            List <Employee> employees = new List<Employee>();

            // Create different kinds of employees and add them to the same list
            employees.Add(new SalaryEmployee());
            employees.Add(new HourlyEmployee());

            // Get a custom calculation for each one;
            foreach(Employee employee in employees)
            {
                float pay = employee.CalculatePay();
                Console.WriteLine(pay);
            }
            */
            
            /* Notice that the list is in a list of 'Shape' objects
            That means you can put any Shap objects in there and also,
            any objext where the class inherits from Shape */
            List<Shape> shapes = new List<Shape>();

            Square s1 = new Square("Red", 3);
            shapes.Add(s1);

            Rectangle s2 = new Rectangle("Blue", 4, 5);
            shapes.Add(s2);

            Circle s3 = new Circle("Pink", 6);
            shapes.Add(s3);

            foreach (Shape s in shapes)
            {
                //Notice that all shapes have a GetColor method from the base class
                string color = s.GetColor();

                // Notice that all shapes have a GetArea method, but the behavior is
                // different fro each type of shape
                double area = s.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}");
            }
        }
    }
}