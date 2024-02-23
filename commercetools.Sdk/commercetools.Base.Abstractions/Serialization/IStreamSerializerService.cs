using System.IO;

namespace commercetools.Base.Serialization
{
    public interface IStreamSerializerService : ISerializerService
    {
        T Deserialize<T>(Stream inputStream);
    }
}
