/*
 * Class: Tictactoe
 * Description: This class represents the TicTacToe game, handling the game logic, players, and game flow.
 */
public class Tictactoe
{
    // The grid array represents the 9 cells of the TicTacToe board
    private string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    // Two players in the game
    private Player player1;
    private Player player2;

    // Keeps track of whose turn it is
    private Player currentPlayer;

    // Constructor to initialize the game with two players
    public Tictactoe(Player p1, Player p2)
    {
        player1 = p1;
        player2 = p2;
        currentPlayer = player1; // Player 1 starts by default
    }

    // Starts the game loop, managing turns and checking game status
    public void StartGame()
    {
        while (!IsGameOver())
        {
            Console.Clear();
            PrintGrid(); // Display the current state of the board
            Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Symbol}): ");
            string choice = Console.ReadLine();

            // Validate the move input
            if (IsValidMove(choice))
            {
                MakeMove(Convert.ToInt32(choice) - 1); // Make the player's move
                SwitchPlayer(); // Switch to the next player
            }
            else
            {
                // Invalid move handling
                Console.WriteLine("Invalid move. Please try again.");
                System.Threading.Thread.Sleep(2000); // Pause for a moment to show error message
            }
        }

        // Display the final grid and game result
        Console.Clear();
        PrintGrid();
        Console.WriteLine(IsGameOver() ? "Game Over!" : "");
    }

    // Displays the current grid
    private void PrintGrid()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------"); // Row divider
            for (int j = 0; j < 3; j++)
            {
                // Print each cell with a vertical separator
                Console.Write("| " + grid[i * 3 + j] + " ");
            }
            Console.WriteLine("|"); // End of row
        }
        Console.WriteLine("-------------"); // Final row divider
    }

    // Validates if the player's move is allowed (choosing a free cell)
    private bool IsValidMove(string choice)
    {
        // A move is valid if the choice is a number that hasn't been played yet
        return grid.Contains(choice) && choice != "X" && choice != "O";
    }

    // Places the current player's symbol in the selected grid position
    private void MakeMove(int index)
    {
        grid[index] = currentPlayer.Symbol;
    }

    // Switches to the other player's turn
    private void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == player1) ? player2 : player1;
    }

    // Checks if the game is over either by a win or a draw
    private bool IsGameOver()
    {
        return CheckWinner() || IsGridFull(); // A game ends if there's a winner or no more moves
    }

    // Checks if there is a winner by evaluating all winning combinations
    private bool CheckWinner()
    {
        // All possible winning combinations on the TicTacToe grid
        string[,] winningCombinations = new string[,]
        {
            { grid[0], grid[1], grid[2] }, // Top row
            { grid[3], grid[4], grid[5] }, // Middle row
            { grid[6], grid[7], grid[8] }, // Bottom row
            { grid[0], grid[3], grid[6] }, // Left column
            { grid[1], grid[4], grid[7] }, // Middle column
            { grid[2], grid[5], grid[8] }, // Right column
            { grid[0], grid[4], grid[8] }, // Diagonal from top-left to bottom-right
            {
                grid[2],
                grid[4],
                grid[6],
            } // Diagonal from top-right to bottom-left
            ,
        };

        // Loop through all winning combinations
        for (int i = 0; i < 8; i++)
        {
            // Check if all three positions in a winning combination are the same symbol
            if (
                winningCombinations[i, 0] == winningCombinations[i, 1]
                && winningCombinations[i, 1] == winningCombinations[i, 2]
            )
            {
                // Announce the winner
                Console.WriteLine($"{currentPlayer.Name} ({currentPlayer.Symbol}) wins!");
                return true;
            }
        }
        return false; // No winner found
    }

    // Checks if the grid is full, which means the game is a draw
    private bool IsGridFull()
    {
        // If none of the grid cells contain their original numbers, the grid is full
        return !grid.Contains("1")
            && !grid.Contains("2")
            && !grid.Contains("3")
            && !grid.Contains("4")
            && !grid.Contains("5")
            && !grid.Contains("6")
            && !grid.Contains("7")
            && !grid.Contains("8")
            && !grid.Contains("9");
    }
}
