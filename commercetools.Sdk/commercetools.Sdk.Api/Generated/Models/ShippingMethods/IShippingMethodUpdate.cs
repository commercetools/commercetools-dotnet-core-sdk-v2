using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodUpdate))]
    public partial interface IShippingMethodUpdate 
    {
        long Version { get; set;}
        
        List<IShippingMethodUpdateAction> Actions { get; set;}
    }
}
