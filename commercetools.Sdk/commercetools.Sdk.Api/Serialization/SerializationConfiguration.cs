using System;
using System.Collections.Generic;

namespace commercetools.Sdk.Api.Serialization
{
    public class SerializationConfiguration : ISerializationConfiguration
    {
        public static readonly ISerializationConfiguration DefaultConfig = new SerializationConfiguration();
        public bool DeserializeNumberAttributeAsDecimalOnly { get; set; } = false;
        public bool DeserializeNumberCustomFieldAsDecimalOnly { get; set; } = false;

        public Dictionary<string, Type> AttributeTypeMap { get; set; } = new Dictionary<string, Type>();
    }
}