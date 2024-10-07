using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangePlainEnumValueOrderAction))]
    public partial interface IProductTypeChangePlainEnumValueOrderAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IList<IAttributePlainEnumValue> Values { get; set; }

        IEnumerable<IAttributePlainEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

    }
}
