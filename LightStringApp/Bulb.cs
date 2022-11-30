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
        StringBuilder s = new StringBuilder();
        string bulbState = this.State? "ON" : "OFF";
        s.Append("Serial numer: "+this.SerialNumber+" State: " + bulbState);
        return s.ToString();
    }
}