using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartUpdate))]
    public partial interface ICartUpdate
    {
        long Version { get; set; }

        List<ICartUpdateAction> Actions { get; set; }
    }
}
