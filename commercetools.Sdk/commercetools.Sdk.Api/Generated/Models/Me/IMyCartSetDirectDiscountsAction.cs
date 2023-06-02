using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetDirectDiscountsAction))]
    public partial interface IMyCartSetDirectDiscountsAction : IMyCartUpdateAction
    {
        IList<IDirectDiscountDraft> Discounts { get; set; }
        IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }


    }
}
