using System.Text;

namespace Builder;

public abstract class Person
{
    /// <summary>
    /// Словарь содержит всю информацию о сущности. Ключ string - имя свойства (например - ФИО),
    /// KeyValuePair<Type, object> - само свойство, его тип
    /// </summary>
    protected Dictionary<string, KeyValuePair<Type, object>> _properties { get; set; } = new();
    public virtual void SetProperty(KeyValuePair<string, KeyValuePair<Type, object>> props) => _properties.Add(props.Key, props.Value);

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-------------------------------");
        sb.AppendLine($"Информация о {GetType().Name}");
        foreach (var prop in _properties)
        {
            sb.AppendLine($"{prop.Key}: {prop.Value.Value}");
        }

        return sb.ToString();
    }
}