using commercetools.Api.Models.Carts;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSignin))]
    public partial interface ICustomerSignin 
    {
        string Email { get; set;}
        
        string Password { get; set;}
        
        [ObsoleteAttribute("This property is obsolete", false)]
        string AnonymousCartId { get; set;}
        
        ICartResourceIdentifier AnonymousCart { get; set;}
        
        IAnonymousCartSignInMode AnonymousCartSignInMode { get; set;}
        
        string AnonymousId { get; set;}
        
        bool? UpdateProductData { get; set;}
    }
}
