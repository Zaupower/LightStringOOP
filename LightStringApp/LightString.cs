using System.IO.Compression;

namespace LightController;

public abstract class LightString<T> where T : Bulb
{
    public List<T> Bulbs;
    public abstract List<T> LightsState();
}