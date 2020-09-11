using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSignin 
    {
        public string Email { get; set;}
        
        public string Password { get; set;}
        
        public string AnonymousCartId { get; set;}
        
        public AnonymousCartSignInMode AnonymousCartSignInMode { get; set;}
        
        public string AnonymousId { get; set;}
        
        public bool UpdateProductData { get; set;}
    }
}
