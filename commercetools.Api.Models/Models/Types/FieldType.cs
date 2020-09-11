using commercetools.Api.Models.Types;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    [JsonConverter(typeof(JsonSubtypes), "name")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldEnumType), "Enum")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldBooleanType), "Boolean")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldReferenceType), "Reference")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldLocalizedEnumType), "LocalizedEnum")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldDateType), "Date")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldMoneyType), "Money")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldSetType), "Set")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldNumberType), "Number")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldLocalizedStringType), "LocalizedString")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldDateTimeType), "DateTime")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldStringType), "String")]
    [JsonSubtypes.KnownSubType(typeof(CustomFieldTimeType), "Time")]
    public abstract class FieldType 
    {
        public string Name { get; set;}
    }
}
