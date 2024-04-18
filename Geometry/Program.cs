using GeometryLib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string> {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        Console.WriteLine("Enter dimensions for Square (side length):");
        double squareSide = double.Parse(Console.ReadLine());

        if (await featureManager.IsEnabledAsync("Square"))
        {
            IShape square = new Square(squareSide);
            Console.WriteLine($"Area of Square: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Square feature is disabled.");
        }

        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Enter dimensions for Rectangle (length and width):");
            double rectangleLength = double.Parse(Console.ReadLine());
            double rectangleWidth = double.Parse(Console.ReadLine());
             var rectangle = new Rectangle(rectangleLength, rectangleWidth);
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Rectangle feature is disabled.");
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Enter dimensions for Triangle (side1, side2, side3):");
            double triangleSide1 = double.Parse(Console.ReadLine());
            double triangleSide2 = double.Parse(Console.ReadLine());
            double triangleSide3 = double.Parse(Console.ReadLine());
            IShape triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Area of Triangle: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Triangle feature is disabled.");
        }
    }
}