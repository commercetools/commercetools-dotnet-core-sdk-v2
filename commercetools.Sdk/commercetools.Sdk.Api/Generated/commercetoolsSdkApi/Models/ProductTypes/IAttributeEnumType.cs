using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.AttributeEnumType))]
    public partial interface IAttributeEnumType : IAttributeType
    {
        IList<IAttributePlainEnumValue> Values { get; set; }
        IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }


    }
}
