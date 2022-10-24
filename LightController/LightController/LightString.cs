namespace LightController;

public abstract class LightString<T> where T : Bulb
{
    public abstract List<T> LightsState();
}