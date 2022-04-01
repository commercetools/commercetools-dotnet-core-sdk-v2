using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Name))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeBooleanType))]
    [SubTypeDiscriminator("date", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeDateType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("money", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeMoneyType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeNestedType))]
    [SubTypeDiscriminator("number", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeNumberType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType))]
    [SubTypeDiscriminator("set", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeSetType))]
    [SubTypeDiscriminator("text", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeTimeType))]
    public partial interface IAttributeType
    {
        string Name { get; set; }
    }
}
