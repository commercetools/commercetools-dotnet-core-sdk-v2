using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeAttributeOrderByNameAction))]
    public partial interface IProductTypeChangeAttributeOrderByNameAction : IProductTypeUpdateAction
    {
        IList<string> AttributeNames { get; set; }

        IEnumerable<string> AttributeNamesEnumerable { set => AttributeNames = value.ToList(); }

    }
}
