using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSignin 
    {
        public string Email { get; set;}
        
        public string Password { get; set;}
        
        public string AnonymousCartId { get; set;}
        
        public string AnonymousCartSignInMode { get; set;}
        
        [JsonIgnore]
        public AnonymousCartSignInMode AnonymousCartSignInModeAsEnum => this.AnonymousCartSignInMode.GetEnum<AnonymousCartSignInMode>();
        
        public string AnonymousId { get; set;}
        
        public bool UpdateProductData { get; set;}
    }
}
