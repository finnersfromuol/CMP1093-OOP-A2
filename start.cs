using System;

public class Program
{
    public static void Main()
    {
        // create a new game instance
        Game game = new Game();
        
        // start and play Sevens Out game
        SevensOut sevensOut = game.StartSevensOut();
        Console.WriteLine("🎲 sevens out final score: " + sevensOut.Play());
        game.stats.Update("sevens", sevensOut.Total);
        
        // start and play Three Or More game
        ThreeOrMore threeOrMore = game.StartThreeOrMore();
        Console.WriteLine("🎲 three or more final score: " + threeOrMore.Play());
        game.stats.Update("three_more", threeOrMore.Total);
        
        // view and print game statistics
        var stats = game.ViewStats();
        Console.WriteLine("📊 game statistics: " + string.Join(", ", stats.Select(kv => $"{kv.Key}: plays={kv.Value.plays}, high={kv.Value.high}")));
        
        // run tests to ensure correctness
        game.RunTests();
        Console.WriteLine("🧪 tests have been run");
    }
}
