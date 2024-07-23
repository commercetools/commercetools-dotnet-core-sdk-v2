using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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

        static commercetools.Sdk.ImportApi.Models.Customfields.BooleanField Boolean(Action<commercetools.Sdk.ImportApi.Models.Customfields.BooleanField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.BooleanField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField BooleanSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.DateField Date(Action<commercetools.Sdk.ImportApi.Models.Customfields.DateField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.DateField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.DateSetField DateSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.DateSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.DateSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.DateTimeField DateTime(Action<commercetools.Sdk.ImportApi.Models.Customfields.DateTimeField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.DateTimeField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.DateTimeSetField DateTimeSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.DateTimeSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.DateTimeSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.EnumField Enum(Action<commercetools.Sdk.ImportApi.Models.Customfields.EnumField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.EnumField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.EnumSetField EnumSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.EnumSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.EnumSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumField LocalizedEnum(Action<commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField LocalizedEnumSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringField LocalizedString(Action<commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringSetField LocalizedStringSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.MoneyField Money(Action<commercetools.Sdk.ImportApi.Models.Customfields.MoneyField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.MoneyField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField MoneySet(Action<commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.MoneySetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.NumberField Number(Action<commercetools.Sdk.ImportApi.Models.Customfields.NumberField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.NumberField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.NumberSetField NumberSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.NumberSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.NumberSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.ReferenceField Reference(Action<commercetools.Sdk.ImportApi.Models.Customfields.ReferenceField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.ReferenceField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.ReferenceSetField ReferenceSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.ReferenceSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.ReferenceSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.StringField String(Action<commercetools.Sdk.ImportApi.Models.Customfields.StringField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.StringField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.StringSetField StringSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.StringSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.StringSetField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.TimeField Time(Action<commercetools.Sdk.ImportApi.Models.Customfields.TimeField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.TimeField();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Customfields.TimeSetField TimeSet(Action<commercetools.Sdk.ImportApi.Models.Customfields.TimeSetField> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Customfields.TimeSetField();
            init?.Invoke(t);
            return t;
        }
    }
}
