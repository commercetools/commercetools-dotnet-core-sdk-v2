using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Customfields.CustomField))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.ImportApi.Models.Customfields.BooleanField))]
    [SubTypeDiscriminator("BooleanSet", typeof(commercetools.ImportApi.Models.Customfields.BooleanSetField))]
    [SubTypeDiscriminator("Date", typeof(commercetools.ImportApi.Models.Customfields.DateField))]
    [SubTypeDiscriminator("DateSet", typeof(commercetools.ImportApi.Models.Customfields.DateSetField))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.ImportApi.Models.Customfields.DateTimeField))]
    [SubTypeDiscriminator("DateTimeSet", typeof(commercetools.ImportApi.Models.Customfields.DateTimeSetField))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.ImportApi.Models.Customfields.EnumField))]
    [SubTypeDiscriminator("EnumSet", typeof(commercetools.ImportApi.Models.Customfields.EnumSetField))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumField))]
    [SubTypeDiscriminator("LocalizedEnumSet", typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.ImportApi.Models.Customfields.LocalizedStringField))]
    [SubTypeDiscriminator("LocalizedStringSet", typeof(commercetools.ImportApi.Models.Customfields.LocalizedStringSetField))]
    [SubTypeDiscriminator("Money", typeof(commercetools.ImportApi.Models.Customfields.MoneyField))]
    [SubTypeDiscriminator("MoneySet", typeof(commercetools.ImportApi.Models.Customfields.MoneySetField))]
    [SubTypeDiscriminator("Number", typeof(commercetools.ImportApi.Models.Customfields.NumberField))]
    [SubTypeDiscriminator("NumberSet", typeof(commercetools.ImportApi.Models.Customfields.NumberSetField))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.ImportApi.Models.Customfields.ReferenceField))]
    [SubTypeDiscriminator("ReferenceSet", typeof(commercetools.ImportApi.Models.Customfields.ReferenceSetField))]
    [SubTypeDiscriminator("String", typeof(commercetools.ImportApi.Models.Customfields.StringField))]
    [SubTypeDiscriminator("StringSet", typeof(commercetools.ImportApi.Models.Customfields.StringSetField))]
    [SubTypeDiscriminator("Time", typeof(commercetools.ImportApi.Models.Customfields.TimeField))]
    [SubTypeDiscriminator("TimeSet", typeof(commercetools.ImportApi.Models.Customfields.TimeSetField))]
    public partial interface ICustomField
    {
        string Type { get; set; }
    }
}
