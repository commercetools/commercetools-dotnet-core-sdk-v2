using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeLocalizedEnumType))]
    public partial interface IAttributeLocalizedEnumType : IAttributeType
    {
        IList<IAttributeLocalizedEnumValue> Values { get; set; }
        IEnumerable<IAttributeLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
