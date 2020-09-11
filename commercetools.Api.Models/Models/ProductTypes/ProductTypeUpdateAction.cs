using commercetools.Api.Models.ProductTypes;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    [JsonConverter(typeof(JsonSubtypes), "action")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeAddAttributeDefinitionAction), "addAttributeDefinition")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeAddLocalizedEnumValueAction), "addLocalizedEnumValue")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeAddPlainEnumValueAction), "addPlainEnumValue")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeAttributeConstraintAction), "changeAttributeConstraint")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeAttributeNameAction), "changeAttributeName")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeAttributeOrderAction), "changeAttributeOrder")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeAttributeOrderByNameAction), "changeAttributeOrderByName")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeDescriptionAction), "changeDescription")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeEnumKeyAction), "changeEnumKey")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeInputHintAction), "changeInputHint")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeIsSearchableAction), "changeIsSearchable")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeLabelAction), "changeLabel")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeLocalizedEnumValueLabelAction), "changeLocalizedEnumValueLabel")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeLocalizedEnumValueOrderAction), "changeLocalizedEnumValueOrder")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangeNameAction), "changeName")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangePlainEnumValueLabelAction), "changePlainEnumValueLabel")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeChangePlainEnumValueOrderAction), "changePlainEnumValueOrder")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeRemoveAttributeDefinitionAction), "removeAttributeDefinition")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeRemoveEnumValuesAction), "removeEnumValues")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeSetInputTipAction), "setInputTip")]
    [JsonSubtypes.KnownSubType(typeof(ProductTypeSetKeyAction), "setKey")]
    public abstract class ProductTypeUpdateAction 
    {
        public string Action { get; set;}
    }
}
