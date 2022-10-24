using System.Text;

namespace LightController;

public class Bulb
{
    private bool state;
    private int SerialNumber;

    public Bulb(int serialNumber)
    {
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
    public void SetState(bool state)
    {
        this.state = state;
    }

    public bool GetState()
    {
        return this.state;
    }
    public override string ToString()
    {
        StringBuilder s = new StringBuilder();
        string bulbState = state? "ON" : "OFF";
        s.Append("Serial numer: "+GetSerialNumber()+" State: " + bulbState);
        return s.ToString();
    }
}