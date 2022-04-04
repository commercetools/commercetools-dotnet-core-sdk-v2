using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFieldLocalizedEnumType))]
    public partial interface ICustomFieldLocalizedEnumType : IFieldType
    {
        List<ICustomFieldLocalizedEnumValue> Values { get; set; }
    }
}
