using commercetools.Api.Models.ProductTypes;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    [JsonConverter(typeof(JsonSubtypes), "name")]
    [JsonSubtypes.KnownSubType(typeof(AttributeMoneyType), "money")]
    [JsonSubtypes.KnownSubType(typeof(AttributeNestedType), "nested")]
    [JsonSubtypes.KnownSubType(typeof(AttributeBooleanType), "boolean")]
    [JsonSubtypes.KnownSubType(typeof(AttributeReferenceType), "reference")]
    [JsonSubtypes.KnownSubType(typeof(AttributeNumberType), "number")]
    [JsonSubtypes.KnownSubType(typeof(AttributeSetType), "set")]
    [JsonSubtypes.KnownSubType(typeof(AttributeEnumType), "enum")]
    [JsonSubtypes.KnownSubType(typeof(AttributeDateType), "date")]
    [JsonSubtypes.KnownSubType(typeof(AttributeTextType), "text")]
    [JsonSubtypes.KnownSubType(typeof(AttributeDateTimeType), "datetime")]
    [JsonSubtypes.KnownSubType(typeof(AttributeTimeType), "time")]
    [JsonSubtypes.KnownSubType(typeof(AttributeLocalizedEnumType), "lenum")]
    [JsonSubtypes.KnownSubType(typeof(AttributeLocalizableTextType), "ltext")]
    public abstract class AttributeType 
    {
        public string Name { get; set;}
    }
}
