using Builder.Models;
using Builder.Properties;

namespace Builder.Builders;

public class StudentBuilder : Builder
{
    public override Builder CreateBase()
    {
        _person = new Student();
        return this;
    }

    public override Builder SetPrivateMembers(params object[] parameters)
    {
        var direction = new DirectionStudyProperty()
        {
            Code = parameters[0].ToString(),
            Name = parameters[1].ToString()
        };
        
        _person.SetProperty(new KeyValuePair<string, KeyValuePair<Type, object>>("Факультет", 
            new KeyValuePair<Type, object>(direction.GetType(), direction)));

        return this;
    }
}