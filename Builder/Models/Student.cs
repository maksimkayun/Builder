namespace Builder.Models;

public class Student : Person
{
    public override void SetProperty(KeyValuePair<string, KeyValuePair<Type, object>> props)
    {
        throw new NotImplementedException();
    }
}