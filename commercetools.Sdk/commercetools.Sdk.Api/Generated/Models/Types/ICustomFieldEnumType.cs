using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldEnumType))]
    public partial interface ICustomFieldEnumType : IFieldType
    {
        List<ICustomFieldEnumValue> Values { get; set;}
    }
}
