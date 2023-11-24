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
        foreach (var parameter in parameters)
        {
            switch (parameter)
            {
                case ScoreProperty score:
                    _person.SetProperty(new KeyValuePair<string, object>("Количество баллов", score));
                    break;
                case DirectionStudyProperty direction:
                    _person.SetProperty(new KeyValuePair<string,  object>("Направление подачи документов", direction));
                    break;
            }
        }
        
        return this;
    }
}