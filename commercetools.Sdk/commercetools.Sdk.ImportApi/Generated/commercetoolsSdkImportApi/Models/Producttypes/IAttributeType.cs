using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
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

        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeBooleanType Boolean(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeBooleanType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeBooleanType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateType Date(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateTimeType Datetime(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateTimeType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeDateTimeType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType Enum(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizedEnumType Lenum(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizedEnumType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizedEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizableTextType Ltext(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizableTextType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizableTextType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeMoneyType Money(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeMoneyType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeMoneyType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNestedType Nested(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNestedType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNestedType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNumberType Number(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNumberType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeNumberType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeReferenceType Reference(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeReferenceType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeReferenceType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeSetType Set(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeSetType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeSetType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTextType Text(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTextType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTextType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTimeType Time(Action<commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTimeType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Producttypes.AttributeTimeType();
            init?.Invoke(t);
            return t;
        }
    }
}
