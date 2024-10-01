Main();

void Main()
{
    try
    {
        Console.WriteLine("PLease enter rectangle length");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter rectangle width");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calling the method and storing the result
        double area = CalculateArea(length, width);

        // Output the result
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

// Method declaration
// 'CalculateArea' is the method name
// 'double' is the return type
// 'double length' and 'double width' are parameters
static double CalculateArea(double length, double width)
{
    // Method body
    double area = length * width;
    return area; // Returning the calculated area
}