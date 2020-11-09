using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [TypeDiscriminator(nameof(Name))]
    [SubTypeDiscriminator("Date", typeof(commercetools.Api.Models.Types.CustomFieldDateType))]
    [SubTypeDiscriminator("Set", typeof(commercetools.Api.Models.Types.CustomFieldSetType))]
    [SubTypeDiscriminator("Reference", typeof(commercetools.Api.Models.Types.CustomFieldReferenceType))]
    [SubTypeDiscriminator("DateTime", typeof(commercetools.Api.Models.Types.CustomFieldDateTimeType))]
    [SubTypeDiscriminator("LocalizedString", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedStringType))]
    [SubTypeDiscriminator("Enum", typeof(commercetools.Api.Models.Types.CustomFieldEnumType))]
    [SubTypeDiscriminator("LocalizedEnum", typeof(commercetools.Api.Models.Types.CustomFieldLocalizedEnumType))]
    [SubTypeDiscriminator("Number", typeof(commercetools.Api.Models.Types.CustomFieldNumberType))]
    [SubTypeDiscriminator("Time", typeof(commercetools.Api.Models.Types.CustomFieldTimeType))]
    [SubTypeDiscriminator("Boolean", typeof(commercetools.Api.Models.Types.CustomFieldBooleanType))]
    [SubTypeDiscriminator("Money", typeof(commercetools.Api.Models.Types.CustomFieldMoneyType))]
    [SubTypeDiscriminator("String", typeof(commercetools.Api.Models.Types.CustomFieldStringType))]
    public partial interface IFieldType 
    {
        string Name { get; set;}
    }
}
