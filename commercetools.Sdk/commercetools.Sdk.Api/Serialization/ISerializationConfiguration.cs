using System;
using System.Collections.Generic;

namespace commercetools.Sdk.Api.Serialization
{
    public interface ISerializationConfiguration
    {
        bool DeserializeNumberAttributeAsDecimalOnly { get; set; }

        bool DeserializeNumberCustomFieldAsDecimalOnly { get; set; }

        Dictionary<string, Type> AttributeTypeMap { get; set; }
    }
}