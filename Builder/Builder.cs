using Builder.Properties;

namespace Builder;

public abstract class Builder
{
    protected Person _person { get; set; }
    
    public abstract Builder CreateBase();
    public Person ReturnCompletePerson() => _person;

    public virtual Builder SetName(string firstName, string? midName, string lastName)
    {
        var prop = new NameProperty
        {
            FirstName = firstName,
            MiddleName = midName,
            LastName = lastName
        };

        _person.SetProperty(new KeyValuePair<string, KeyValuePair<Type, object>>("ФИО",
            new KeyValuePair<Type, object>(prop.GetType(), prop)));
        return this;
    }

    public virtual Builder SetAddress(string postal, string region, string city, string street)
    {
        var prop = new AddressProperty()
        {
            Postal = postal.Replace("  ", " ").Trim(),
            Region = region.Replace("  ", " ").Trim(),
            Town = city.Replace("  ", " ").Trim(),
            Street = street.Replace("  ", " ").Trim()
        };
        
        _person.SetProperty(new KeyValuePair<string, KeyValuePair<Type, object>>("Адрес",
            new KeyValuePair<Type, object>(prop.GetType(), prop)));
        
        return this;
    }

    public abstract Builder SetPrivateMembers(params object[] parameters);
    public T ReturnCompleteConcretePerson<T>() where T : Person =>
        _person as T ??
        throw new InvalidCastException($"The requested person is not the specified type {typeof(T).Name}. " +
                                       $"Type of person: {_person.GetType().Name}");
}