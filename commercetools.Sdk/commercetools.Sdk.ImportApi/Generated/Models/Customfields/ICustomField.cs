using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.ImportApi.Models.Customfields.BooleanField))]
    [SubTypeDiscriminator("String", typeof(commercetools.ImportApi.Models.Customfields.StringField))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.ImportApi.Models.Customfields.LocalizedStringField))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.ImportApi.Models.Customfields.EnumField))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumField))]
    [SubTypeDiscriminator("Number", typeof(commercetools.ImportApi.Models.Customfields.NumberField))]
    [SubTypeDiscriminator("Money", typeof(commercetools.ImportApi.Models.Customfields.MoneyField))]
    [SubTypeDiscriminator("Date", typeof(commercetools.ImportApi.Models.Customfields.DateField))]
    [SubTypeDiscriminator("Time", typeof(commercetools.ImportApi.Models.Customfields.TimeField))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.ImportApi.Models.Customfields.DateTimeField))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.ImportApi.Models.Customfields.ReferenceField))]
    [SubTypeDiscriminator("BooleanSet", typeof(commercetools.ImportApi.Models.Customfields.BooleanSetField))]
    [SubTypeDiscriminator("StringSet", typeof(commercetools.ImportApi.Models.Customfields.StringSetField))]
    [SubTypeDiscriminator("LocalizedStringSet", typeof(commercetools.ImportApi.Models.Customfields.LocalizedStringSetField))]
    [SubTypeDiscriminator("EnumSet", typeof(commercetools.ImportApi.Models.Customfields.EnumSetField))]
    [SubTypeDiscriminator("LocalizedEnumSet", typeof(commercetools.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    [SubTypeDiscriminator("NumberSet", typeof(commercetools.ImportApi.Models.Customfields.NumberSetField))]
    [SubTypeDiscriminator("MoneySet", typeof(commercetools.ImportApi.Models.Customfields.MoneySetField))]
    [SubTypeDiscriminator("DateSet", typeof(commercetools.ImportApi.Models.Customfields.DateSetField))]
    [SubTypeDiscriminator("TimeSet", typeof(commercetools.ImportApi.Models.Customfields.TimeSetField))]
    [SubTypeDiscriminator("DateTimeSet", typeof(commercetools.ImportApi.Models.Customfields.DateTimeSetField))]
    [SubTypeDiscriminator("ReferenceSet", typeof(commercetools.ImportApi.Models.Customfields.ReferenceSetField))]
    public partial interface ICustomField 
    {
        string Type { get; set;}
    }
}
