using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Producttypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        IList<IAttributePlainEnumValue> Values { get; set; }

        IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

    }
}
