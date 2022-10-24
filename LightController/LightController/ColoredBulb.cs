using System.Text;

namespace LightController;

public class ColoredBulb : Bulb 
{
    private Color color;
    private int SerialNumber;

    public ColoredBulb(Color color, int serialNumber)
    {
        SetColor(color);
        SetSerialNumber(serialNumber);
    }

    public void SetSerialNumber(int serialNumber)
    {
        this.SerialNumber = serialNumber;
    }

    public int GetSerialNumber()
    {
        return this.SerialNumber;
    }

    public void SetColor(Color color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return this.color.ToString();
    }
    
    public override string ToString()
    {
        StringBuilder s = new StringBuilder();
        string bulbState = GetState()? "ON" : "OFF";
        s.Append("Serial number: "+this.SerialNumber+" State: " + bulbState +" Color: "+ GetColor());
        return s.ToString();
    }
}