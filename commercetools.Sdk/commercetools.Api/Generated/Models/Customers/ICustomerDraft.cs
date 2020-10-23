using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Stores;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerDraft 
    {
        string CustomerNumber { get; set;}
        
        string Email { get; set;}
        
        string Password { get; set;}
        
        string FirstName { get; set;}
        
        string LastName { get; set;}
        
        string MiddleName { get; set;}
        
        string Title { get; set;}
        
        string AnonymousCartId { get; set;}
        
        string AnonymousId { get; set;}
        
        DateTime DateOfBirth { get; set;}
        
        string CompanyName { get; set;}
        
        string VatId { get; set;}
        
        List<IAddress> Addresses { get; set;}
        
        long DefaultShippingAddress { get; set;}
        
        List<int> ShippingAddresses { get; set;}
        
        long DefaultBillingAddress { get; set;}
        
        List<int> BillingAddresses { get; set;}
        
        bool IsEmailVerified { get; set;}
        
        string ExternalId { get; set;}
        
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Locale { get; set;}
        
        string Salutation { get; set;}
        
        string Key { get; set;}
        
        List<IStoreResourceIdentifier> Stores { get; set;}
    }
}
