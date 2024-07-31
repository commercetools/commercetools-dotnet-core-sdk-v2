using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
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

        static commercetools.Sdk.ImportApi.Models.Productvariants.BooleanAttribute Boolean(Action<commercetools.Sdk.ImportApi.Models.Productvariants.BooleanAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.BooleanAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.BooleanSetAttribute BooleanSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.BooleanSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.BooleanSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.DateAttribute Date(Action<commercetools.Sdk.ImportApi.Models.Productvariants.DateAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.DateAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.DateSetAttribute DateSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.DateSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.DateSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeAttribute Datetime(Action<commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute DatetimeSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.DateTimeSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.EnumAttribute Enum(Action<commercetools.Sdk.ImportApi.Models.Productvariants.EnumAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.EnumAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.EnumSetAttribute EnumSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.EnumSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.EnumSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumAttribute Lenum(Action<commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute LenumSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableEnumSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextAttribute Ltext(Action<commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextSetAttribute LtextSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.MoneyAttribute Money(Action<commercetools.Sdk.ImportApi.Models.Productvariants.MoneyAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.MoneyAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute MoneySet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.MoneySetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.NumberAttribute Number(Action<commercetools.Sdk.ImportApi.Models.Productvariants.NumberAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.NumberAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.NumberSetAttribute NumberSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.NumberSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.NumberSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceAttribute Reference(Action<commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceSetAttribute ReferenceSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.TextAttribute Text(Action<commercetools.Sdk.ImportApi.Models.Productvariants.TextAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.TextAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.TextSetAttribute TextSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.TextSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.TextSetAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.TimeAttribute Time(Action<commercetools.Sdk.ImportApi.Models.Productvariants.TimeAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.TimeAttribute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Productvariants.TimeSetAttribute TimeSet(Action<commercetools.Sdk.ImportApi.Models.Productvariants.TimeSetAttribute> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Productvariants.TimeSetAttribute();
            init?.Invoke(t);
            return t;
        }
    }
}
