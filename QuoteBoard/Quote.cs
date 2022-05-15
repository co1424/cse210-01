public class Quote {
    private string author = "";
    private string quote = "";
    private Source source;
    public Quote(string person, string quote, Source source){ // This is the constructor! 
        this.author = person;
        this.quote = quote;
        this.source = source;
    }

    public bool HasAuthor(string name){
        if(author.ToUpper().Contains(name.ToUpper())){
            return true;
        }
        return false;
    }

    public string GetQuote(){
        string url = source.geturl();
        url = url != "" ? $"[{url}]" : "";
        // This is the same... Just like we did above.
        // if(url!=""){
        //     url = $"[{url}}";
        // }
        // else {
        //     url = "";
        // }
        return $"\"{quote}\" {author} - {source.getName()}{url}";
    }


}