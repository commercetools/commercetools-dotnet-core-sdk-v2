using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodUpdate))]
    public partial interface IShippingMethodUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IShippingMethodUpdate, IShippingMethodUpdateAction>
    {
        new long Version { get; set; }
        new List<IShippingMethodUpdateAction> Actions { get; set; }

    }
}
