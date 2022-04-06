using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Customfields.CustomField))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanField))]
    [SubTypeDiscriminator("BooleanSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateField))]
    [SubTypeDiscriminator("DateSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateSetField))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateTimeField))]
    [SubTypeDiscriminator("DateTimeSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.DateTimeSetField))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Sdk.ImportApi.Models.Customfields.EnumField))]
    [SubTypeDiscriminator("EnumSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.EnumSetField))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumField))]
    [SubTypeDiscriminator("LocalizedEnumSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringField))]
    [SubTypeDiscriminator("LocalizedStringSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringSetField))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Sdk.ImportApi.Models.Customfields.MoneyField))]
    [SubTypeDiscriminator("MoneySet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Sdk.ImportApi.Models.Customfields.NumberField))]
    [SubTypeDiscriminator("NumberSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.NumberSetField))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Sdk.ImportApi.Models.Customfields.ReferenceField))]
    [SubTypeDiscriminator("ReferenceSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.ReferenceSetField))]
    [SubTypeDiscriminator("String", typeof(commercetools.Sdk.ImportApi.Models.Customfields.StringField))]
    [SubTypeDiscriminator("StringSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.StringSetField))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Sdk.ImportApi.Models.Customfields.TimeField))]
    [SubTypeDiscriminator("TimeSet", typeof(commercetools.Sdk.ImportApi.Models.Customfields.TimeSetField))]
    public partial interface ICustomField
    {
        string Type { get; set; }
    }
}
