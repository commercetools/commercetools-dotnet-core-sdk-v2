using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Api.Models.Types.CustomFieldReferenceType))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedEnumType))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Api.Models.Types.CustomFieldDateType))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Api.Models.Types.CustomFieldNumberType))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedStringType))]
    [SubTypeDiscriminator("Set", typeof(commercetools.Api.Models.Types.CustomFieldSetType))]
    [SubTypeDiscriminator("String", typeof(commercetools.Api.Models.Types.CustomFieldStringType))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Api.Models.Types.CustomFieldMoneyType))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Api.Models.Types.CustomFieldEnumType))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Api.Models.Types.CustomFieldBooleanType))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Api.Models.Types.CustomFieldDateTimeType))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Api.Models.Types.CustomFieldTimeType))]
    public interface IFieldType 
    {
        string Name { get; set;}
    }
}
