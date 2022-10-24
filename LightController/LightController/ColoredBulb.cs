namespace LightController;

public class ColoredBulb : Bulb 
{
    private Color color;

    public ColoredBulb(Color color)
    {
        SetColor(color);
    }
    public void SetColor(Color color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return this.color.ToString();
    }
}