using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldLocalizedEnumType))]
    public partial interface ICustomFieldLocalizedEnumType : IFieldType
    {
        IList<ICustomFieldLocalizedEnumValue> Values { get; set; }
        IEnumerable<ICustomFieldLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
