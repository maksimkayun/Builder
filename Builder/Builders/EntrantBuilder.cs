using Builder.Models;
using Builder.Properties;

namespace Builder.Builders;

public class EntrantBuilder : Builder
{
    public override Builder CreateBase()
    {
        _person = new Entrant();
        return this;
    }

    public override Builder SetName(string firstName, string? midName, string lastName)
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

    public override Builder SetAddress(string postal, string region, string city, string street)
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
}