public class Player {
    Deck deck; // If you are going to use this class in this other class, define it like shown here.

    int score;

    int previousCard;

    int nextCard;

    public Player() {
        this.score = 300; // "this" refers to the "score" variable defined above.
        this.deck = new Deck(); // New refers to use the "Deck" class.
        previousCard = this.deck.GetRandomNumber(); // This is getting the number from the method in the "Deck" class.
    }

    public void StartGame() {
        string choice = "";
        bool keepPlaying = true;

        while (keepPlaying) { // While keep playing is true, keep looping.
            Console.WriteLine($"The card was: {previousCard}");
            choice = this.cardDecision(choice);

            nextCard = this.getNextCardAndShow(nextCard);
            score = this.AssignPoints(choice, nextCard, previousCard);

            Console.WriteLine($"Your score is: {score}");

            Console.WriteLine("Play again? [y/n]");
            string answer = Console.ReadLine();

            if (answer == "N" || answer == "n") {
                keepPlaying = false;
            }

            previousCard = nextCard; // This is replacing the previous card.

        }
    }

    public string cardDecision(string choice) { // You need to define the data type in the () as well.
        Console.WriteLine("Higher or Lower? [h/l]");
        choice = Console.ReadLine();

        if (choice != "h" || choice != "l") {
            this.cardDecision();
        }

        return choice;
    }

    public int getNextCardAndShow(int nextCard) {
        nextCard = this.deck.GetRandomNumber();
        Console.WriteLine($"The new card is: {nextCard}.");

        return nextCard;
    }

    public int AssignPoints(string choice, int nextCard, int previousCard) {
        if (choice == "h" && nextCard > previousCard) {
            score += 100;
        } else if (choice == "l" && nextCard < previousCard) {
            score += 100;
        } else if (choice == "h" && nextCard < previousCard) {
            score -= 75;
        } else if (choice == "l" && nextCard > previousCard) {
            score -=75;
        }

        return score;
    }
}