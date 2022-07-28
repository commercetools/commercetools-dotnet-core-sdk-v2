using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.ItemShippingDetails))]
    public partial interface IItemShippingDetails
    {
        List<IItemShippingTarget> Targets { get; set; }

        bool Valid { get; set; }

    }
}
