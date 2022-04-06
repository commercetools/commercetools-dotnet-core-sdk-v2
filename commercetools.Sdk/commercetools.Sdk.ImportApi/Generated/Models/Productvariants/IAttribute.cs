using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.Attribute))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.BooleanAttribute))]
    [SubTypeDiscriminator("boolean-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.BooleanSetAttribute))]
    [SubTypeDiscriminator("date", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateAttribute))]
    [SubTypeDiscriminator("date-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateSetAttribute))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeAttribute))]
    [SubTypeDiscriminator("datetime-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.EnumAttribute))]
    [SubTypeDiscriminator("enum-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.EnumSetAttribute))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumAttribute))]
    [SubTypeDiscriminator("lenum-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextAttribute))]
    [SubTypeDiscriminator("ltext-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextSetAttribute))]
    [SubTypeDiscriminator("money", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.MoneyAttribute))]
    [SubTypeDiscriminator("money-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute))]
    [SubTypeDiscriminator("number", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.NumberAttribute))]
    [SubTypeDiscriminator("number-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.NumberSetAttribute))]
    [SubTypeDiscriminator("reference", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceAttribute))]
    [SubTypeDiscriminator("reference-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceSetAttribute))]
    [SubTypeDiscriminator("text", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TextAttribute))]
    [SubTypeDiscriminator("text-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TextSetAttribute))]
    [SubTypeDiscriminator("time", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TimeAttribute))]
    [SubTypeDiscriminator("time-set", typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TimeSetAttribute))]
    public partial interface IAttribute
    {
        string Name { get; set; }

        string Type { get; set; }
    }
}
