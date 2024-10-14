/*
 * Project: C# Mini Projects
 * Author: Onur Onel
 * Date: October 14, 2024
 * Description: This program creates two players and initializes a TicTacToe game between them.
 *              It uses the Player and Tictactoe classes to manage the game flow.
 */
public class Program
{
    public static void Main(string[] args)
    {
        // Create two players with their respective names and symbols
        Player player1 = new Player("Player 1", "X");
        Player player2 = new Player("Player 2", "O");

        // Create a new TicTacToe game with the two players
        Tictactoe game = new Tictactoe(player1, player2);

        // Start the TicTacToe game
        game.StartGame();
    }
}
