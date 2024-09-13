using System.Text.Json;

namespace Olbrasoft.Serialization;

public class MicrosoftJsonSerializer : ISerializer
{
    public TValue? Deserialize<TValue>(string value)
    {
        return JsonSerializer.Deserialize<TValue>(value);
    }

    public string Serialize(object? value)
    {
        return JsonSerializer.Serialize(value); 
    }
}
