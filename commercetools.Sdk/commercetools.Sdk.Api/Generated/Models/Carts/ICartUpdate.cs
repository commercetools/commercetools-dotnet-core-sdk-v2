using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartUpdate))]
    public partial interface ICartUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<ICartUpdate, ICartUpdateAction>
    {
        new long Version { get; set; }
        new List<ICartUpdateAction> Actions { get; set; }
    }
}
