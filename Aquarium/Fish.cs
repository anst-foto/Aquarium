namespace Aquarium;

public class Fish
{
    public string Name { get; init; }
    public int MaxAge { get; init; }

    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                _age = 0;
            }

            _age = value > MaxAge ? MaxAge : value;
        }
    }
    
    public bool IsDead => Age >= MaxAge;
}