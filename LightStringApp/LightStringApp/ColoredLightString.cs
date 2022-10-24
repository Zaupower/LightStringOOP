using System.Dynamic;

namespace LightController;

public class ColoredLightString : LightString<ColoredBulb>
{
    
    public List<ColoredBulb> ColoredBulbs = new List<ColoredBulb>();
    
    public ColoredLightString(int[] serialNumbers)
    {
        for (int i = 0; i < serialNumbers.Length; i++)
        {
            ColoredBulb coloredBulb = new ColoredBulb(GetColor(serialNumbers[i]), serialNumbers[i]);
            ColoredBulbs.Add(coloredBulb);
        }
    }

    private Color GetColor(int serialNumber)
    {
        
        int counter = 2;
        int colorIndex = 2;

        //Second state exists because 4%2 = 0 but 
        //by multiplicity rule where:
        // a is multiple of b if there are an x where 
        // a=bx, so 2=4x is not possible, so 
        // a bulb with an serial number 2 cannot be yellow(2)
        if (serialNumber <= counter || serialNumber == 4)
        {
            Console.WriteLine("serialNumber: " + serialNumber);
            return (Color)serialNumber;
        }

        while (serialNumber % counter != 0)
        {
            counter++;
            colorIndex++;
            if (colorIndex > 4)
            {
                colorIndex = 1;
            }
        } 

        Console.WriteLine("ColorIndex: " + colorIndex  + " counter: " + counter);
        return (Color)colorIndex;
    }

    public override List<ColoredBulb> LightsState()
    {
        //set state 
        foreach (var coloredBulb in ColoredBulbs)
        {
            int minute = 0;
            int.TryParse(DateTime.Now.ToString("mm"),out minute);
            if (minute%2==0)
            {
                coloredBulb.SetState(true);
            }
            else
            {
                coloredBulb.SetState(false);
            }
            
            //set bulbs state and the return them
        }

        return this.ColoredBulbs;
    }
}