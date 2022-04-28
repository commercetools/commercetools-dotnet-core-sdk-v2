namespace commercetools.Sdk.Api.Serialization
{
    public class SerializationConfiguration : ISerializationConfiguration
    {
        public static readonly SerializationConfiguration DefaultConfig = new SerializationConfiguration();
        public bool DeserializeNumberAttributeAsDecimalOnly { get; set; }

        public SerializationConfiguration()
        {
            this.DeserializeNumberAttributeAsDecimalOnly = false;
        }
    }
}