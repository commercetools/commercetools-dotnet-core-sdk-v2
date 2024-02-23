using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDirectDiscountsAction))]
    public partial interface IStagedOrderSetDirectDiscountsAction : IStagedOrderUpdateAction
    {
        IList<IDirectDiscountDraft> Discounts { get; set; }
        IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }


    }
}
