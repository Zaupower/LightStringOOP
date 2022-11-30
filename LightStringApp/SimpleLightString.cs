namespace LightController;

public class SimpleLightString : LightString<Bulb>
{
    
    public SimpleLightString(int[] serialNumbers)
    {
        for (int i = 0; i < serialNumbers.Length; i++)
        {
            Bulb bulb = new Bulb( serialNumbers[i]);
            this.Bulbs.Add(bulb);
        }
    }
    public override List<Bulb> LightsState()
    {
        //set state 
        foreach (var bulb in Bulbs)
        {
            int minute = DateTime.Now.Minute;
            
            if (minute%2==0)
            { 
                if(bulb.SerialNumber%2 == 0)
                {
                    bulb.State = true; 
                }
                else
                {
                    bulb.State = false;
                }
            }
            else
            {
                if (bulb.SerialNumber % 2 == 0)
                {
                    bulb.State = false;
                }
                else
                {
                    bulb.State = true;
                }
            }
            //set bulbs state and the return them
        }
        return this.Bulbs;
    }
}