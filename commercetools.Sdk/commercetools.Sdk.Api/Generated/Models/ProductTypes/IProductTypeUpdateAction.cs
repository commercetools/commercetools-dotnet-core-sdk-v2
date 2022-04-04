using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeUpdateAction))]
    [SubTypeDiscriminator("addAttributeDefinition", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddAttributeDefinitionAction))]
    [SubTypeDiscriminator("addLocalizedEnumValue", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddLocalizedEnumValueAction))]
    [SubTypeDiscriminator("addPlainEnumValue", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeAddPlainEnumValueAction))]
    [SubTypeDiscriminator("changeAttributeConstraint", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeConstraintAction))]
    [SubTypeDiscriminator("changeAttributeName", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeNameAction))]
    [SubTypeDiscriminator("changeAttributeOrder", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderAction))]
    [SubTypeDiscriminator("changeAttributeOrderByName", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction))]
    [SubTypeDiscriminator("changeDescription", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeDescriptionAction))]
    [SubTypeDiscriminator("changeEnumKey", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction))]
    [SubTypeDiscriminator("changeInputHint", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeInputHintAction))]
    [SubTypeDiscriminator("changeIsSearchable", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeIsSearchableAction))]
    [SubTypeDiscriminator("changeLabel", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueLabel", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    [SubTypeDiscriminator("changeLocalizedEnumValueOrder", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeNameAction))]
    [SubTypeDiscriminator("changePlainEnumValueLabel", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueLabelAction))]
    [SubTypeDiscriminator("changePlainEnumValueOrder", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction))]
    [SubTypeDiscriminator("removeAttributeDefinition", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveAttributeDefinitionAction))]
    [SubTypeDiscriminator("removeEnumValues", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeRemoveEnumValuesAction))]
    [SubTypeDiscriminator("setInputTip", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetInputTipAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeSetKeyAction))]
    public partial interface IProductTypeUpdateAction
    {
        string Action { get; set; }
    }
}
