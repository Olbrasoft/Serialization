namespace Olbrasoft.Serialization;
public interface ISerializer
{
    string Serialize(object? value);
    TValue? Deserialize<TValue>(string value);

}
