using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSignin))]
    public partial interface ICustomerSignin 
    {
        string Email { get; set;}
        
        string Password { get; set;}
        
        string AnonymousCartId { get; set;}
        
        string AnonymousCartSignInMode { get; set;}
        
        AnonymousCartSignInMode AnonymousCartSignInModeAsEnum { get; }
        
        string AnonymousId { get; set;}
        
        bool? UpdateProductData { get; set;}
    }
}
