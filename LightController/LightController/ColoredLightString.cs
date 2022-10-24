using System.Dynamic;

namespace LightController;

public class ColoredLightString : LightString<ColoredBulb>
{
    
    public List<ColoredBulb> ColoredBulbs = new List<ColoredBulb>();
    
    public ColoredLightString(int serialNumber, int length)
    {
        for (int i = 0; i < length; i++)
        {
            ColoredBulb coloredBulb = new ColoredBulb(GetColor(serialNumber));
            ColoredBulbs.Add(coloredBulb);
        }
    }

    private Color GetColor(int serialNumber)
    {
        int colorCounter = 1;
        try
        {
            for (int i = 1; i < serialNumber; i++)
            {
                if (colorCounter > 4)
                    colorCounter = 1;
                
                if ((serialNumber%i) == 0)
                {
                    return SelectColor(colorCounter);
                }

                colorCounter++;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return Color.NONE;
    }

    private Color SelectColor(int index)
    {
        switch (index)
        {
           case 1:
               return Color.RED;
           break;
           case 2:
               return Color.BLUE;
           break;
           case 3:
               return Color.GREEN;
           break;
           case 4:
               return Color.YELLOW;
        }

        return Color.NONE;
    }

    public override List<ColoredBulb> LightsState()
    {
        //set state 
        foreach (var coloredBulb in ColoredBulbs)
        {
            String minute = DateTime.Now.ToString("mm");
            Console.WriteLine(minute);
            //set bulbs state and the return them
        }

        return this.ColoredBulbs;
    }
}