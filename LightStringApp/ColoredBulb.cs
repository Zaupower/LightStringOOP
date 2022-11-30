using System.Text;

namespace LightController;

public class ColoredBulb : Bulb 
{
    public Color Color { get; set; }

    public ColoredBulb(Color color, int serialNumber) : base(serialNumber)
    {
        this.Color = color;
        this.SerialNumber = serialNumber;
    }
    
    public override string ToString()
    {
        StringBuilder s = new StringBuilder();
        string bulbState = this.State? "ON" : "OFF";
        s.Append("Serial number: "+this.SerialNumber+" State: " + bulbState +" Color: "+ this.Color);
        return s.ToString();
    }
}