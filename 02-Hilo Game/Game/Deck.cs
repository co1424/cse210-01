public class Deck {

    public int card; // Define datatype. 

    public Deck() { // The constructor is used to run something right when the program starts.
    }

    //This is a method. (This is the same thing as a function, but it's called a method when it's inside a class.)
    public int GetRandomNumber() { 
        Random random = new Random();
        card = random.Next(1,14);

        return card;

    }


}