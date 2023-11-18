namespace Builder.Models;

public class Entrant : Person
{
    public override void SetProperty(KeyValuePair<string, KeyValuePair<Type, object>> props)
    {
        _properties.Add(props.Key, props.Value);
    }
}