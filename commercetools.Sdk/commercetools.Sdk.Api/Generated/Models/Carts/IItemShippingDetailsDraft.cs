using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft
    {
        List<IItemShippingTarget> Targets { get; set; }
    }
}
