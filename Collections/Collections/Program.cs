using Collection; 
public class Program
{
    static void Main(string[] args)
    {

        var result = Generics.Add<string>("ayush", " juyal");
        Console.WriteLine(result);

        var result2 = Generics.Add<int>(10, 20);
        Console.WriteLine(result2); 
    }
}