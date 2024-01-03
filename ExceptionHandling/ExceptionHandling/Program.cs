using ParsingHtml.Models;
using ParsingHtml.Services;

namespace ParsingHtml {
    public class Program
    {
        static void Main(string[] args)
        {

            Employee e = new("Ayush", 23, "12344", 23000, "SDE", "SD1");
            ParseHtml.AddDataToFile(e);
        }

    }
}