using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [TypeDiscriminator(nameof(Name))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeBooleanType))]
    [SubTypeDiscriminator("date", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("money", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeMoneyType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNestedType))]
    [SubTypeDiscriminator("number", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNumberType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeReferenceType))]
    [SubTypeDiscriminator("set", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeSetType))]
    [SubTypeDiscriminator("text", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTimeType))]
    public partial interface IAttributeType
    {
        string Name { get; set; }
    }
}
