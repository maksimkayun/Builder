namespace Builder.Properties;

public class NameProperty
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }

    public override string ToString() =>
        MiddleName == default ? $"{LastName} {FirstName}" : $"{LastName} {MiddleName} {FirstName}";
}