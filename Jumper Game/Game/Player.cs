public class Player {
    string randomWord;
    public Player() {
        Puzzle puzzle = new Puzzle();
        randomWord = puzzle.GetRandomWord();
        Console.WriteLine(randomWord);



    }

    // This begins the game:

      
    // Here the user inputs the guessed letters:
    public string letterChoice(string letterChoice){
        Console.WriteLine("Guess a letter [a-z]: ");
        letterChoice = Console.ReadLine();
        
        return letterChoice;
        


    }




}