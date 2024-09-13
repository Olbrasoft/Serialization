using System.Text.Json;

namespace Olbrasoft.Serialization.Tests;
public class MicrosoftJsonSerializerTests
{
    //JsonSerializer is public class
    [Fact]
    public void MicrosoftJsonSerializer_Is_Public_Class()
    {
        //Arrange
        var type = typeof(MicrosoftJsonSerializer);

        //Act
        var isPublic = type.IsPublic;

        //Assert
        Assert.True(isPublic);
    }

    //MicrosoftJsonSerializer assembly is Olbrasoft.Serialization
    [Fact]
    public void MicrosoftJsonSerializer_Assembly_Is_Olbrasoft_Serialization()
    {
        //Arrange
        var type = typeof(MicrosoftJsonSerializer);

        //Act
        var assembly = type.Assembly.GetName().Name;

        //Assert
        Assert.Equal("Olbrasoft.Serialization", assembly);
    }

    //MicrosoftJsonSerializer namespace is Olbrasoft.Serialization
    [Fact]
    public void MicrosoftJsonSerializer_Namespace_Is_Olbrasoft_Serialization()
    {
        //Arrange
        var type = typeof(MicrosoftJsonSerializer);

        //Act
        var @namespace = type.Namespace;

        //Assert
        Assert.Equal("Olbrasoft.Serialization", @namespace);
    }

    //MicrosoftJsonSerializer is ISerializer
    [Fact]
    public void MicrosoftJsonSerializer_Is_ISerializer()
    {
        //Arrange
        var type = typeof(MicrosoftJsonSerializer);

        //Act
        var isISerializer = type.GetInterfaces().Contains(typeof(ISerializer));

        //Assert
        Assert.True(isISerializer);
    }

    //Serialize pingObject return string
    [Fact]
    public void Serialize_PingObject_Return_String()
    {
        //Arrange
        var serializer = new MicrosoftJsonSerializer();
        var pingObject = new PingObject();

        //Act
        var result = serializer.Serialize(pingObject);

        //Assert
        Assert.IsType<string>(result);
    }

    //Deserialize string return pingObject
    [Fact]
    public void Deserialize_String_Return_PingObject()
    {
        //Arrange
        var serializer = new MicrosoftJsonSerializer();
        var pingObject = new PingObject();
        var serialized = serializer.Serialize(pingObject);

        //Act
        var result = serializer.Deserialize<PingObject>(serialized);

        //Assert
        Assert.IsType<PingObject>(result);
    }



}
