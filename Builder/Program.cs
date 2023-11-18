

using Builder.Builders;
using Builder.Models;

namespace Builder;

public static class Program
{
    public static void Main(string[] args)
    {
        Director director = new Director(new EntrantBuilder());
        director.Construct();
        Entrant entrant = director.GetResult<Entrant>();
        
        Console.WriteLine(entrant.ToString());
    }
}