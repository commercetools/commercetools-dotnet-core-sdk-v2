using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerSignin 
    {
        public string Email { get; set;}
        
        public string Password { get; set;}
        
        public string AnonymousCartId { get; set;}
        
        public string AnonymousCartSignInMode { get; set;}
        
        public AnonymousCartSignInMode AnonymousCartSignInModeAsEnum => this.AnonymousCartSignInMode.GetEnum<AnonymousCartSignInMode>();
        
        public string AnonymousId { get; set;}
        
        public bool UpdateProductData { get; set;}
    }
}
