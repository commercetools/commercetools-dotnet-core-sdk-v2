using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.CustomFieldEnumType))]
    public partial interface ICustomFieldEnumType : IFieldType
    {
        IList<ICustomFieldEnumValue> Values { get; set; }
        IEnumerable<ICustomFieldEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
