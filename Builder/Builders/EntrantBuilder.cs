using Builder.Models;
using Builder.Properties;

namespace Builder.Builders;

public class EntrantBuilder : Builder
{
    public EntrantBuilder()
    {
    }

    public override Builder CreateBase()
    {
        _person = new Entrant();
        return this;
    }

    public override Builder SetPrivateMembers(params object[] parameters)
    {
        var score = new ScoreProperty
        {
            Score = int.TryParse(parameters[0] as string, out int result) ? result : 0
        };
        
        _person.SetProperty(new KeyValuePair<string, KeyValuePair<Type, object>>("Количество баллов", 
            new KeyValuePair<Type, object>(score.GetType(), score)));

        var direction = new DirectionStudyProperty
        {
            Code = parameters[1].ToString(),
            Name = parameters[2].ToString()
        };

        _person.SetProperty(new KeyValuePair<string, KeyValuePair<Type, object>>("Направление подачи документов",
            new KeyValuePair<Type, object>(direction.GetType(), direction)));

        return this;
    }
}