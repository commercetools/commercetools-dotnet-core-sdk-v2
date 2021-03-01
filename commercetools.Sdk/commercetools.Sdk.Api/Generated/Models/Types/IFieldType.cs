using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Api.Models.Types.CustomFieldDateTimeType))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Api.Models.Types.CustomFieldTimeType))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Api.Models.Types.CustomFieldEnumType))]
    [SubTypeDiscriminator("String", typeof(commercetools.Api.Models.Types.CustomFieldStringType))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Api.Models.Types.CustomFieldBooleanType))]
    [SubTypeDiscriminator("Set", typeof(commercetools.Api.Models.Types.CustomFieldSetType))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Api.Models.Types.CustomFieldDateType))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Api.Models.Types.CustomFieldMoneyType))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedEnumType))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Api.Models.Types.CustomFieldNumberType))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Api.Models.Types.CustomFieldReferenceType))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedStringType))]
    public partial interface IFieldType 
    {
        string Name { get; set;}
    }
}
