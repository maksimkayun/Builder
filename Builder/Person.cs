using System.Text;

namespace Builder;

public abstract class Person
{
    /// <summary>
    /// Словарь содержит всю информацию о сущности. Ключ string - имя свойства (например - ФИО),
    /// object - само свойство
    /// </summary>
    protected Dictionary<string,  object> _properties { get; set; } = new();
    public virtual void SetProperty(KeyValuePair<string,  object> props) => _properties.Add(props.Key, props.Value);

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-------------------------------");
        sb.AppendLine($"Информация о {GetType().Name}");
        foreach (var prop in _properties)
        {
            sb.AppendLine($"{prop.Key}: {prop.Value}");
        }

        return sb.ToString();
    }
}