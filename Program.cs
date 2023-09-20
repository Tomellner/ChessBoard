namespace ChessBoard
//Tom Ellner NET23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Prompt the user to enter a number.
            Console.WriteLine("Var god mata in en siffra:");
            // Read the user input and convert it to an integer.
            int number = Int32.Parse(Console.ReadLine());
            // Initialize a variable to keep track of the current position within a row.
            int indexNumber = 0;
            // Define Unicode characters for black and white squares.
            string black = "◻︎";
            string white = "◼︎";
            // Iterate through each row of the chessboard.
            for (int row = 0; row < number; row++)
            {
                // Check if the current row is even or odd.
                if (row%2 == 0)
                {
                    // For even rows, alternate between printing black and white squares for each column.
                    for (int column = 0; column < number; column++)
                    {
                        // Check if the current position is within the specified number of columns.
                        if (indexNumber < number)
                        {
                            // Print a black square.
                            Console.Write(black);
                            indexNumber++;
                        }
                        // Check if the current position is within the specified number of columns.
                        if (indexNumber < number)
                        {
                            // Print a white square.
                            Console.Write(white);
                            indexNumber++;
                        }
                    }
                }
                else
                {
                    // For odd rows, alternate between printing white and black squares for each column.
                    for (int column = 0; column < number; column++)
                    {
                        // Check if the current position is within the specified number of columns.
                        if (indexNumber < number)
                        {
                            // Print a white square.
                            Console.Write(white);
                            indexNumber++;
                        }
                        // Check if the current position is within the specified number of columns.
                        if (indexNumber < number)
                        {
                            // Print a black square.
                            Console.Write(black);
                            indexNumber++;
                        }
                    }
                }
                // Move to the next line after completing a row.
                Console.WriteLine();
                // Reset the current position to the beginning of the row.
                indexNumber = 0;
            }
        }
    }
}