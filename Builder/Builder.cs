namespace Builder;

public abstract class Builder
{
    protected Person _person { get; set; }
    
    public abstract Builder CreateBase();
    public Person ReturnCompletePerson() => _person;

    public abstract Builder SetName(string firstName, string? midName, string lastName);
    public abstract Builder SetAddress(string postal, string region, string city, string street);
    public T ReturnCompleteConcretePerson<T>() where T : Person =>
        _person as T ??
        throw new InvalidCastException($"The requested person is not the specified type {typeof(T).Name}. " +
                                       $"Type of person: {_person.GetType().Name}");
}