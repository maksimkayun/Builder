

using Builder.Builders;
using Builder.Models;
using Builder.Properties;

namespace Builder;

public static class Program
{
    public static void Main(string[] args)
    {
        Director director = new Director(new EntrantBuilder());
        director.Construct(otherParams: new object[]
        {
            new ScoreProperty
            {
                Score = 100
            },
            new DirectionStudyProperty
            {
                Code = "09.03.01",
                Name = "Информатика и вычислительная техника"
            }
        });
        Entrant entrant = director.GetResult<Entrant>();
        
        Console.WriteLine(entrant.ToString());
        
        Director director2 = new Director(new StudentBuilder());
        director2.Construct(otherParams: new DirectionStudyProperty
        {
            Code = "09.03.01",
            Name = "Информатика и вычислительная техника"
        });
        var person = director2.GetResult();
        Console.WriteLine(person.ToString());
    }
}