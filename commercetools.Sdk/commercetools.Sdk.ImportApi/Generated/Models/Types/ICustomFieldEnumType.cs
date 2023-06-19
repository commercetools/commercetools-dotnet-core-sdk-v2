using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldEnumType))]
    public partial interface ICustomFieldEnumType : IFieldType
    {
        IList<ICustomFieldEnumValue> Values { get; set; }
        IEnumerable<ICustomFieldEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
