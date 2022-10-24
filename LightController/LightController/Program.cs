using LightController;

class Program
{
    static void Main(string[] args)
    {
        int[] serials = { 1, 2, 3, 4, 5, 6, 7 };

        Console.WriteLine(0%2);
        Console.WriteLine(2%2);
        Console.WriteLine(3%2);
        
        ColoredLightString coloredLightString = new ColoredLightString(serials);

        SimpleLightString simpleLightString = new SimpleLightString(serials);
        
        foreach (var coloredBulb in coloredLightString.LightsState())
        {
            Console.WriteLine(coloredBulb.ToString());
        }
    }
}