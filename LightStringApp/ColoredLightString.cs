using System.Dynamic;

namespace LightController;

public class ColoredLightString : LightString<ColoredBulb>
{
    public ColoredLightString(int[] serialNumbers)
    {
        for (int i = 0; i < serialNumbers.Length; i++)
        {
            ColoredBulb coloredBulb = new ColoredBulb(GetColor(serialNumbers[i]), serialNumbers[i]);
            Bulbs.Add(coloredBulb);
        }
    }

    /// <summary>
    /// 1. Pls, use propertis instead of Get Set methods. 
    /// 2. Bulbs field of 'SimpleLightString' and 'ColoredLightString' classes can be moved to base class. 
    /// 3. it works wrong now, odd and even bulbs should blink every minute in rotation
    /// </summary>
    /// <param name="serialNumber"></param>
    /// <returns></returns>
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
        return (Color)colorIndex;
    }

    public override List<ColoredBulb> LightsState()
    {
        //VERIFICAR SERIAL NUMBER PARA DECIDIR SE FICA ON OU OFF
        //set state 
        foreach (var coloredBulb in Bulbs)
        {
            int minute = DateTime.Now.Minute;
            if (minute%2==0)
            {
                coloredBulb.State = true;
            }
            else
            {
                coloredBulb.State = false;
            }
            //set bulbs state and the return them
        }
        return this.Bulbs;
    }
}