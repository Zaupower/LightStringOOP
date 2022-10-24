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

        int enumsLength = Enum.GetNames(typeof(Color)).Length;
        int counter = enumsLength+1;
        int colorIndex = 1;
        if (serialNumber < counter)
        {
            Console.WriteLine("serialNumber: " + serialNumber);
            return (Color)serialNumber;
        }

        do
        {
            counter++;
            if (colorIndex > 4)
            {
                colorIndex = 1; 
                
            }else { colorIndex++; }
        } while (serialNumber%counter != 0 && colorIndex <= 4 );

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