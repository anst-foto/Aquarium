using Aquarium;

var aquarium = new global::Aquarium.Aquarium()
{
    NumberOfFish = 3
};

var result = aquarium.AddFish(new Fish()
{
    Name = "Dori",
    MaxAge = 3,
    Age = 0
});
if (!result)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Больше рыбок добавлять нельзя!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Рыбка добавлена!");
    Console.ResetColor();
}

result = aquarium.AddFish(new Fish()
{
    Name = "Nemo",
    MaxAge = 4,
    Age = 2
});
if (!result)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Больше рыбок добавлять нельзя!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Рыбка добавлена!");
    Console.ResetColor();
}

result = aquarium.AddFish(new Fish()
{
    Name = "Dori 2",
    MaxAge = 3,
    Age = 0
});
if (!result)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Больше рыбок добавлять нельзя!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Рыбка добавлена!");
    Console.ResetColor();
}


result = aquarium.AddFish(new Fish());
if (!result)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Больше рыбок добавлять нельзя!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Рыбка добавлена!");
    Console.ResetColor();
}

var fishes = aquarium.Fishes;
do
{
    for (var i = fishes.Count - 1; i >= 0; i--)
    {
        fishes[i].Age++;

        if (fishes[i].IsDead)
        {
            aquarium.DelFish(fishes[i]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Рыбка умерла!");
            Console.ResetColor();
        }
    }
} while (aquarium.Fishes.Count > 0);
