namespace LightController;

public class SimpleLightString : LightString<Bulb>
{
    public List<Bulb> Bulbs = new List<Bulb>();
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
            int minute = 0;
            int.TryParse(DateTime.Now.ToString("mm"),out minute);
            if (minute%2==0)
            { bulb.SetState(true); }
            else
            { bulb.SetState(false); }
            //set bulbs state and the return them
        }
        return this.Bulbs;
    }
}