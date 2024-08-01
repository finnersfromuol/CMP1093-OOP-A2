using System;

public class Die
{
    public int Value { get; private set; }

    public Die()
    {
        // initialize the die with a default value of 1
        Value = 1;
    }

    public int Roll()
    {
        // roll the die and return a random integer between 1 and 6
        Random rand = new Random();
        Value = rand.Next(1, 7);
        return Value;
    }
}
