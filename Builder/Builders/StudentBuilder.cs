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
        foreach (var parameter in parameters)
        {
            switch (parameter)
            {
                case DirectionStudyProperty direction:
                    _person.SetProperty(new KeyValuePair<string, object>("Факультет", direction));
                    break;
                    
            }
        }
        
        return this;
    }
}