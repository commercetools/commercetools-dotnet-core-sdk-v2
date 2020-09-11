using commercetools.Api.Models.Types;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(TypeAddEnumValueAction), "addEnumValue")]
    [JsonSubtypes.KnownSubType(typeof(TypeAddFieldDefinitionAction), "addFieldDefinition")]
    [JsonSubtypes.KnownSubType(typeof(TypeAddLocalizedEnumValueAction), "addLocalizedEnumValue")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeEnumValueLabelAction), "changeEnumValueLabel")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeEnumValueOrderAction), "changeEnumValueOrder")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeFieldDefinitionLabelAction), "changeFieldDefinitionLabel")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeFieldDefinitionOrderAction), "changeFieldDefinitionOrder")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeInputHintAction), "changeInputHint")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeKeyAction), "changeKey")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeLabelAction), "changeLabel")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeLocalizedEnumValueLabelAction), "changeLocalizedEnumValueLabel")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeLocalizedEnumValueOrderAction), "changeLocalizedEnumValueOrder")]
    [JsonSubtypes.KnownSubType(typeof(TypeChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(TypeRemoveFieldDefinitionAction), "removeFieldDefinition")]
    [JsonSubtypes.KnownSubType(typeof(TypeSetDescriptionAction), "setDescription")]
    public abstract class TypeUpdateAction 
    {
        public string Action { get; set;}
    }
}
