using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [TypeDiscriminator(nameof(Name))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Producttypes.AttributeType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.ImportApi.Models.Producttypes.AttributeBooleanType))]
    [SubTypeDiscriminator("date", typeof(commercetools.ImportApi.Models.Producttypes.AttributeDateType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.ImportApi.Models.Producttypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.ImportApi.Models.Producttypes.AttributeEnumType))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.ImportApi.Models.Producttypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.ImportApi.Models.Producttypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("money", typeof(commercetools.ImportApi.Models.Producttypes.AttributeMoneyType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.ImportApi.Models.Producttypes.AttributeNestedType))]
    [SubTypeDiscriminator("number", typeof(commercetools.ImportApi.Models.Producttypes.AttributeNumberType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.ImportApi.Models.Producttypes.AttributeReferenceType))]
    [SubTypeDiscriminator("set", typeof(commercetools.ImportApi.Models.Producttypes.AttributeSetType))]
    [SubTypeDiscriminator("text", typeof(commercetools.ImportApi.Models.Producttypes.AttributeTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.ImportApi.Models.Producttypes.AttributeTimeType))]
    public partial interface IAttributeType 
    {
        string Name { get; set;}
    }
}
