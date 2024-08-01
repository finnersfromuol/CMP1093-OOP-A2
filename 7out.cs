public class SevensOut
{
    private Die die1;
    private Die die2;
    public int Total { get; private set; }

    public SevensOut()
    {
        // create two dice for the game
        die1 = new Die();
        die2 = new Die();
        Total = 0;
    }

    public int Play()
    {
        // keep rolling the dice until the total is 7
        while (true)
        {
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int rollTotal = roll1 + roll2;

            if (roll1 == roll2)
            {
                // if both dice show the same number (a double), add double the total to the score
                Total += 2 * rollTotal;
            }
            else
            {
                // otherwise, just add the total to the score
                Total += rollTotal;
            }

            if (rollTotal == 7)
            {
                // stop if the total of the dice is 7
                break;
            }
        }

        return Total;
    }
}
