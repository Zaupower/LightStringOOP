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
        int colorIndex = 1;
        if (serialNumber==1)
        {
            return Color.Red;
        }
        while (serialNumber%counter != 0)
        {
            
            counter++;
            if (colorIndex>4)
            {
                colorIndex = 1;
            }
            else
            {
                colorIndex++;
            }
        }
        
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