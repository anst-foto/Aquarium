namespace Aquarium;

public class Aquarium
{
    public List<Fish> Fishes { get; init; } = new List<Fish>();
    
    public uint NumberOfFish { get; init; }

    public bool AddFish(Fish fish)
    {
        if (Fishes.Count >= NumberOfFish) return false;
        
        Fishes.Add(fish);
        return true;
    }

    public bool DelFish(Fish fish)
    {
        if (Fishes.Count == 0) return false;

        Fishes.Remove(fish);
        return true;
    }
}