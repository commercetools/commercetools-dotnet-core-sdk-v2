using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountUpdate))]
    public partial interface ICartDiscountUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICartDiscountUpdate, ICartDiscountUpdateAction>
    {
        new long Version { get; set; }
        new IList<ICartDiscountUpdateAction> Actions { get; set; }
        IEnumerable<ICartDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
