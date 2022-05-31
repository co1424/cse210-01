public class Word {
    public string word;

    // Constructor:
    public Word() {
    }

    // This method returns a random word:
    public string GetRandomWord(){

    // Word list to pass to the GetRandomWord method:
    List<string> wordList = new List<string>();
    wordList.Add("Planetarium");
    wordList.Add("Museum");
    wordList.Add("Stars");
    wordList.Add("Cheese");
    wordList.Add("Computer");
    wordList.Add("Programming");
    wordList.Add("Swimming");
    wordList.Add("Transparent");

    // This counts the number of list items, and picks a random item and stores it into the "word" variable:
    Random random = new Random();
    word = random.Next(wordList.Count);

    // This returns the randome "wordList" index number:
    return wordList[word];
    }
 
}