// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//  ---------------------- QUOTE BOARD PROGRAM --------------------------- //

public class Program {
    static void Main() // Void means that it does not return anything.
    {
        // Source s = new Source("The Living Christ");
        // Console.WriteLine(s.getName());
        Quote q = new Quote("Paul","This a quote by Paul", new Source("2 Timothy 1:7"));// Refer back to the Quote class.
        Console.WriteLine(q.GetQuote()); 
    }
}