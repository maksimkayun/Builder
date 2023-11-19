namespace Builder;

public class Director
{
    private Builder _builder { get; set; }
    public Director(Builder builder)
    {
        _builder = builder;
        _builder.CreateBase();
    }

    public void Construct(string fullName = "Иванов Иван Иванович", string address = "150200, Московская обл., Мытищи, Загородная", params object[] otherParams)
    {
        if (fullName.Contains("  "))
        {
            fullName = fullName.Replace("  ", " ").Trim();
        }
        var splitName = fullName.Split(" ");
        _builder.SetName(splitName[1], splitName.Length > 2 ? splitName[2] : default, splitName[0]);

        if (!string.IsNullOrWhiteSpace(address))
        {
            var splitAddress = address.Trim().Split(",");
            _builder.SetAddress(splitAddress[0], splitAddress[1], splitAddress[2], splitAddress[3]);
        }

        if (otherParams.Any())
        {
            _builder.SetPrivateMembers(otherParams);
        }
    }

    /// <summary>
    /// Возвращает подготовленный объект типа Person
    /// </summary>
    /// <returns></returns>
    public Person GetResult() => _builder.ReturnCompletePerson();
    
    /// <summary>
    /// Возвращает подготовленный объект указанного типа (Person, Entrant, Student, Teacher)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>Подготовленный объект</returns>
    /// <remarks>Запрашиваемый тип должен поддерживать иерархию Person</remarks>
    /// <exception cref="InvalidCastException">Выдаёт ошибку InvalidCastException, если запрашиваемый тип не совпадает с типом подготовленного объекта</exception>
    public T GetResult<T>() where T : Person => _builder.ReturnCompleteConcretePerson<T>();
}