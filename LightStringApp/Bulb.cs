using System.Text;

namespace LightController;

public class Bulb
{
    public bool State { get; set; }
    public int SerialNumber { get; set; }

    public Bulb(int serialNumber)
    {
        this.SerialNumber = serialNumber;
    }
    
    public override string ToString()
    {
        StringBuilder s = new();
        string bulbState = this.State? "ON" : "OFF";
        s.Append("Serial numer: "+this.SerialNumber+" State: " + bulbState);
        return s.ToString();
    }
}