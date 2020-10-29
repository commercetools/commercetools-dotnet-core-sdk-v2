using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomer : IMyCustomer
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public string CustomerNumber { get; set;}
        
        public string Email { get; set;}
        
        public string Password { get; set;}
        
        public string FirstName { get; set;}
        
        public string LastName { get; set;}
        
        public string MiddleName { get; set;}
        
        public string Title { get; set;}
        
        public DateTime DateOfBirth { get; set;}
        
        public string CompanyName { get; set;}
        
        public string VatId { get; set;}
        
        public List<IAddress> Addresses { get; set;}
        
        public string DefaultShippingAddressId { get; set;}
        
        public List<string> ShippingAddressIds { get; set;}
        
        public string DefaultBillingAddressId { get; set;}
        
        public List<string> BillingAddressIds { get; set;}
        
        public bool IsEmailVerified { get; set;}
        
        public string ExternalId { get; set;}
        
        public ICustomerGroupReference CustomerGroup { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public string Locale { get; set;}
        
        public string Salutation { get; set;}
        
        public string Key { get; set;}
        
        public List<IStoreKeyReference> Stores { get; set;}
    }
}
