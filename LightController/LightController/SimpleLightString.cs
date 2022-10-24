namespace LightController;

public class SimpleLightString : LightString<Bulb>
{
    
    public SimpleLightString(int[] serialNumbers)
    {
        for (int i = 0; i < serialNumbers.Length; i++)
        {
            Console.WriteLine("implement me!!");
        }
    }
    public override List<Bulb> LightsState()
    {
        throw new NotImplementedException();
    }
}