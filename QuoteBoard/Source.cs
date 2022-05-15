public class Source{
    private string name = "";
    private string url = "";

    // The way to know this is a constructor is because it has the same name as the "class" above!
    public Source(string name, string url = "") // = "" this means it is optional.
    {
        this.name = name;
        this.url = url;
    }

    public string getName()
    {
        return name;
    }

    public string geturl()
    {
        return url;
    }
}