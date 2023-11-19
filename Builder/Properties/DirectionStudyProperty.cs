namespace Builder.Properties;

public class DirectionStudyProperty
{
    public string Code { get; set; }
    public string Name { get; set; }

    public override string ToString() =>
        $"{Code} - {Name}";
}