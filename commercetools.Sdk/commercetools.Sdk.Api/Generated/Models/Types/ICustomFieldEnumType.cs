using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldEnumType))]
    public partial interface ICustomFieldEnumType : IFieldType
    {
        List<ICustomFieldEnumValue> Values { get; set;}
    }
}
