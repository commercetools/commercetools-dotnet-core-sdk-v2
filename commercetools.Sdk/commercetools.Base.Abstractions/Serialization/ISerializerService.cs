using System;
using System.IO;

namespace commercetools.Base.Serialization
{
    public interface ISerializerService
    {
        string Serialize<T>(T input);

        T Deserialize<T>(string input);
        T Deserialize<T>(Stream inputStream);

        object Deserialize(Type returnType, string input);
    }
}
