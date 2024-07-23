using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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

        static commercetools.Sdk.Api.Models.Types.CustomFieldBooleanType Boolean(Action<commercetools.Sdk.Api.Models.Types.CustomFieldBooleanType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldBooleanType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldDateType Date(Action<commercetools.Sdk.Api.Models.Types.CustomFieldDateType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldDateType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldDateTimeType DateTime(Action<commercetools.Sdk.Api.Models.Types.CustomFieldDateTimeType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldDateTimeType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldEnumType Enum(Action<commercetools.Sdk.Api.Models.Types.CustomFieldEnumType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedEnumType LocalizedEnum(Action<commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedEnumType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedStringType LocalizedString(Action<commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedStringType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedStringType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldMoneyType Money(Action<commercetools.Sdk.Api.Models.Types.CustomFieldMoneyType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldMoneyType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldNumberType Number(Action<commercetools.Sdk.Api.Models.Types.CustomFieldNumberType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldNumberType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldReferenceType Reference(Action<commercetools.Sdk.Api.Models.Types.CustomFieldReferenceType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldReferenceType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldSetType Set(Action<commercetools.Sdk.Api.Models.Types.CustomFieldSetType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldSetType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldStringType String(Action<commercetools.Sdk.Api.Models.Types.CustomFieldStringType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldStringType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Types.CustomFieldTimeType Time(Action<commercetools.Sdk.Api.Models.Types.CustomFieldTimeType> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Types.CustomFieldTimeType();
            init?.Invoke(t);
            return t;
        }
    }
}
