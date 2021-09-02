using System;

namespace commercetools.Base.Serialization
{
    public interface ISerializerService
    {
        string Serialize<T>(T input);

        T Deserialize<T>(string input);

        object Deserialize(Type returnType, string input);
    }
}
