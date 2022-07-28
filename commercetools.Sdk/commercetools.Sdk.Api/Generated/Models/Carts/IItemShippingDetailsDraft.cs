using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft
    {
        List<IItemShippingTarget> Targets { get; set; }

    }
}
