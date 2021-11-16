using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartUpdate))]
    public partial interface ICartUpdate 
    {
        long Version { get; set;}
        
        List<ICartUpdateAction> Actions { get; set;}
    }
}
