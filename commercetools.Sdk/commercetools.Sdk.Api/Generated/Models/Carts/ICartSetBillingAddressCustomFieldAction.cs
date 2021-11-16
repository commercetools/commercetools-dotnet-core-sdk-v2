using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetBillingAddressCustomFieldAction))]
    public partial interface ICartSetBillingAddressCustomFieldAction : ICartUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
