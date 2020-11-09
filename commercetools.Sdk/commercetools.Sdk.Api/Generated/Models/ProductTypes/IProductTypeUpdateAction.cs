using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Action))]
    [SubTypeDiscriminator("addAttributeDefinition", typeof(commercetools.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction))]
    [SubTypeDiscriminator("addLocalizedEnumValue", typeof(commercetools.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction))]
    [SubTypeDiscriminator("addPlainEnumValue", typeof(commercetools.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction))]
    [SubTypeDiscriminator("changeAttributeConstraint", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction))]
    [SubTypeDiscriminator("changeAttributeName", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction))]
    [SubTypeDiscriminator("changeAttributeOrder", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderAction))]
    [SubTypeDiscriminator("changeAttributeOrderByName", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction))]
    [SubTypeDiscriminator("changeDescription", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction))]
    [SubTypeDiscriminator("changeEnumKey", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction))]
    [SubTypeDiscriminator("changeInputHint", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeInputHintAction))]
    [SubTypeDiscriminator("changeIsSearchable", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction))]
    [SubTypeDiscriminator("changeLabel", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueLabel", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueOrder", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeNameAction))]
    [SubTypeDiscriminator("changePlainEnumValueLabel", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction))]
    [SubTypeDiscriminator("changePlainEnumValueOrder", typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction))]
    [SubTypeDiscriminator("removeAttributeDefinition", typeof(commercetools.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction))]
    [SubTypeDiscriminator("removeEnumValues", typeof(commercetools.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction))]
    [SubTypeDiscriminator("setInputTip", typeof(commercetools.Api.Models.ProductTypes.ProductTypeSetInputTipAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.ProductTypes.ProductTypeSetKeyAction))]
    public partial interface IProductTypeUpdateAction 
    {
        string Action { get; set;}
    }
}
