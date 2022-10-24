﻿using LightController;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(59%9);
        int[] serials = { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };
        int[] serialsSimple = { 100, 200, 300, 400, 5900, 644, 711 };
        int minute = 0;
        int.TryParse(DateTime.Now.ToString("mm"),out minute);
        Console.WriteLine("Minute: " + minute);
        
        ColoredLightString coloredLightString = new ColoredLightString(serials);

        SimpleLightString simpleLightString = new SimpleLightString(serialsSimple);

        Console.WriteLine("");
        Console.WriteLine("ColoredLightString");
        foreach (var coloredBulb in coloredLightString.LightsState())
        {
            Console.WriteLine(coloredBulb.ToString());
        }
        
        Console.WriteLine("");
        Console.WriteLine("SimpleLightString");
        foreach (var bulb in simpleLightString.LightsState())
        {
            Console.WriteLine(bulb.ToString());
        }
    }
}