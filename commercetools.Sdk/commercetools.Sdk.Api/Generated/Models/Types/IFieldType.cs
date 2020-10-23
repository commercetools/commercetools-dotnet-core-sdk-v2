using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("Set", typeof(commercetools.Api.Models.Types.CustomFieldSetType))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Api.Models.Types.CustomFieldDateType))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Api.Models.Types.CustomFieldEnumType))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Api.Models.Types.CustomFieldReferenceType))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Api.Models.Types.CustomFieldBooleanType))]
    [SubTypeDiscriminator("String", typeof(commercetools.Api.Models.Types.CustomFieldStringType))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Api.Models.Types.CustomFieldDateTimeType))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedEnumType))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Api.Models.Types.CustomFieldTimeType))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedStringType))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Api.Models.Types.CustomFieldNumberType))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Api.Models.Types.CustomFieldMoneyType))]
    public interface IFieldType 
    {
        string Name { get; set;}
    }
}
