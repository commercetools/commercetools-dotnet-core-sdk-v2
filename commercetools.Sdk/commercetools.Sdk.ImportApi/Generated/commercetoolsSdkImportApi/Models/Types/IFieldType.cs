using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [TypeDiscriminator(nameof(Name))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Types.FieldType))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldBooleanType))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateType))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateTimeType))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumType))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumType))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedStringType))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldMoneyType))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldNumberType))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldReferenceType))]
    [SubTypeDiscriminator("Set", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldSetType))]
    [SubTypeDiscriminator("String", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldStringType))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldTimeType))]
    public partial interface IFieldType
    {
        string Name { get; set; }

        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldBooleanType Boolean(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldBooleanType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldBooleanType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateType Date(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateTimeType DateTime(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateTimeType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldDateTimeType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumType Enum(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumType LocalizedEnum(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedStringType LocalizedString(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedStringType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedStringType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldMoneyType Money(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldMoneyType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldMoneyType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldNumberType Number(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldNumberType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldNumberType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldReferenceType Reference(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldReferenceType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldReferenceType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldSetType Set(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldSetType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldSetType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldStringType String(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldStringType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldStringType();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Types.CustomFieldTimeType Time(Action<commercetools.Sdk.ImportApi.Models.Types.CustomFieldTimeType> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Types.CustomFieldTimeType();
            init?.Invoke(t);
            return t;
        }
    }
}
