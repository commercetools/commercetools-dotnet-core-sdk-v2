using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountUpdate))]
    public partial interface ICartDiscountUpdate
    {
        new long Version { get; set; }
        new IList<ICartDiscountUpdateAction> Actions { get; set; }
        IEnumerable<ICartDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
