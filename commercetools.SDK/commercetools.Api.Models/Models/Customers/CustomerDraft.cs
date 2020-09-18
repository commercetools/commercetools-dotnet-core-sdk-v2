using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerDraft 
    {
        public string CustomerNumber { get; set;}
        
        public string Email { get; set;}
        
        public string Password { get; set;}
        
        public string FirstName { get; set;}
        
        public string LastName { get; set;}
        
        public string MiddleName { get; set;}
        
        public string Title { get; set;}
        
        public string AnonymousCartId { get; set;}
        
        public string AnonymousId { get; set;}
        
        public DateTime DateOfBirth { get; set;}
        
        public string CompanyName { get; set;}
        
        public string VatId { get; set;}
        
        public List<Address> Addresses { get; set;}
        
        public long DefaultShippingAddress { get; set;}
        
        public List<int> ShippingAddresses { get; set;}
        
        public long DefaultBillingAddress { get; set;}
        
        public List<int> BillingAddresses { get; set;}
        
        public bool IsEmailVerified { get; set;}
        
        public string ExternalId { get; set;}
        
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Locale { get; set;}
        
        public string Salutation { get; set;}
        
        public string Key { get; set;}
        
        public List<StoreResourceIdentifier> Stores { get; set;}
    }
}
