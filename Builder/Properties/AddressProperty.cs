namespace Builder.Properties;

public class AddressProperty
{
    public string Postal { get; set; }
    public string Region { get; set; }
    public string Town { get; set; }
    public string Street { get; set; }

    public override string ToString() => $"{Postal}, {Region}, г.{Town}, ул.{Street}";
}