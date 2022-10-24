using LightController;

class Program
{
    static void Main(string[] args)
    {
        int[] serials = { 1, 2, 3, 4, 59, 6, 7 };
        int[] serialsSimple = { 100, 200, 300, 400, 5900, 644, 711 };
        int minute = 0;
        int.TryParse(DateTime.Now.ToString("mm"),out minute);
        Console.WriteLine("Minute: " + minute);
        
        ColoredLightString coloredLightString = new ColoredLightString(serials);

        SimpleLightString simpleLightString = new SimpleLightString(serialsSimple);
        
        foreach (var coloredBulb in coloredLightString.LightsState())
        {
            Console.WriteLine(coloredBulb.ToString());
        }
        
        Console.WriteLine("");
        
        foreach (var bulb in simpleLightString.LightsState())
        {
            Console.WriteLine(bulb.ToString());
        }
    }
}