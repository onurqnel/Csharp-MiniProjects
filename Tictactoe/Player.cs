/*
 * Class: Player
 * Description: This class represents a player in the TicTacToe game, with a name and a symbol ("X" or "O").
 */
public class Player
{
    // Property to store the player's name, with a private set to make it read-only after initialization
    public string Name { get; private set; }

    // Property to store the player's symbol, either "X" or "O", with a private set to make it read-only after initialization
    public string Symbol { get; private set; }

    // Constructor to initialize a player with a name and a symbol
    public Player(string name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}
