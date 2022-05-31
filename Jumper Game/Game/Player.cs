public class Player {

    Word word; 

    string word;

    string letterChoice;


    // This begins the game:
    public void BeginGame() {
        


        Console.ReadLine("- - - - -");
        Console.ReadLine("");
        Console.ReadLine("____");
        Console.ReadLine("/   \\");
        Console.ReadLine("‾‾‾‾");
        Console.ReadLine("\\   /");
        Console.ReadLine("\\  /");
        Console.ReadLine(" O ");
        Console.ReadLine("/|\\");
        Console.ReadLine("/ \\");
        Console.ReadLine("");
        Console.ReadLine("^^^^^^^");
        

    } 
    
     
     
    // Here the user inputs the guessed letters:
    public string letterChoice(string letterChoice){
        Lower.Console.WriteLine("Guess a letter [a-z]: ");
        letterChoice = Console.ReadLine();
        
        


    }




}