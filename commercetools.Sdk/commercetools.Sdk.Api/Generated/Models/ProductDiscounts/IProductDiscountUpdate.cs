using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountUpdate))]
    public partial interface IProductDiscountUpdate
    {
        new long Version { get; set; }
        new IList<IProductDiscountUpdateAction> Actions { get; set; }
        IEnumerable<IProductDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
