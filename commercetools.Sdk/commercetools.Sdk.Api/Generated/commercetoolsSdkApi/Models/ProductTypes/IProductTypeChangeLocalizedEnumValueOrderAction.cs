using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueOrderAction))]
    public partial interface IProductTypeChangeLocalizedEnumValueOrderAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        IList<IAttributeLocalizedEnumValue> Values { get; set; }

        IEnumerable<IAttributeLocalizedEnumValue> ValuesEnumerable { set => Values = value.ToList(); }

    }
}
