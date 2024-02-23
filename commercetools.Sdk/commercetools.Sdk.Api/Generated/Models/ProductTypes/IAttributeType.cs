using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [TypeDiscriminator(nameof(Name))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeType))]
    [SubTypeDiscriminator("boolean", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeBooleanType))]
    [SubTypeDiscriminator("date", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeDateType))]
    [SubTypeDiscriminator("datetime", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeDateTimeType))]
    [SubTypeDiscriminator("enum", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType))]
    [SubTypeDiscriminator("lenum", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumType))]
    [SubTypeDiscriminator("ltext", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizableTextType))]
    [SubTypeDiscriminator("money", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeMoneyType))]
    [SubTypeDiscriminator("nested", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeNestedType))]
    [SubTypeDiscriminator("number", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeNumberType))]
    [SubTypeDiscriminator("reference", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType))]
    [SubTypeDiscriminator("set", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeSetType))]
    [SubTypeDiscriminator("text", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeTextType))]
    [SubTypeDiscriminator("time", typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeTimeType))]
    public partial interface IAttributeType
    {
        string Name { get; set; }

        static commercetools.Sdk.Api.Models.ProductTypes.AttributeBooleanType Boolean(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeBooleanType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeBooleanType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeDateType Date(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeDateType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeDateType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeDateTimeType Datetime(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeDateTimeType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeDateTimeType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType Enum(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumType Lenum(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizedEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizableTextType Ltext(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizableTextType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeLocalizableTextType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeMoneyType Money(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeMoneyType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeMoneyType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeNestedType Nested(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeNestedType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeNestedType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeNumberType Number(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeNumberType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeNumberType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType Reference(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeReferenceType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeSetType Set(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeSetType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeSetType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeTextType Text(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeTextType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeTextType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductTypes.AttributeTimeType Time(Action<commercetools.Sdk.Api.Models.ProductTypes.AttributeTimeType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductTypes.AttributeTimeType();
            init?.Invoke(t);
            return t;
        }
    }
}
