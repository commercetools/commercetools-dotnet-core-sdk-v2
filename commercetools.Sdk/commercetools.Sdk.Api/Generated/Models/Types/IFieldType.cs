using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [TypeDiscriminator(nameof(Name))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Types.FieldType))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldBooleanType))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldDateType))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldDateTimeType))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldEnumType))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedEnumType))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedStringType))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldMoneyType))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldNumberType))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldReferenceType))]
    [SubTypeDiscriminator("Set", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldSetType))]
    [SubTypeDiscriminator("String", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldStringType))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Sdk.Api.Models.Types.CustomFieldTimeType))]
    public partial interface IFieldType
    {
        string Name { get; set; }
    }
}
