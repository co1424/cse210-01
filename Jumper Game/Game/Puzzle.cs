public class Puzzle {
    
    int index;
    Random random = new Random();
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

    index = random.Next(wordList.Count);

    // This returns the randome "wordList" index number:
    return wordList[index];
    }

    public string randomLetter(){
        char [] letterArray = this.GetRandomWord().ToCharArray();
        var newLetter = letterArray.Select(item => item.ToString()).ToList();
    }

    public string singleLetter(){
        
        foreach(var item in wordList.GetRandomWord())
    }




}