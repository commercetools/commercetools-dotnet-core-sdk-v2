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
    public interface ICustomer : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string CustomerNumber { get; set;}
        
        string Email { get; set;}
        
        string Password { get; set;}
        
        string FirstName { get; set;}
        
        string LastName { get; set;}
        
        string MiddleName { get; set;}
        
        string Title { get; set;}
        
        DateTime DateOfBirth { get; set;}
        
        string CompanyName { get; set;}
        
        string VatId { get; set;}
        
        List<IAddress> Addresses { get; set;}
        
        string DefaultShippingAddressId { get; set;}
        
        List<string> ShippingAddressIds { get; set;}
        
        string DefaultBillingAddressId { get; set;}
        
        List<string> BillingAddressIds { get; set;}
        
        bool IsEmailVerified { get; set;}
        
        string ExternalId { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        ICustomFields Custom { get; set;}
        
        string Locale { get; set;}
        
        string Salutation { get; set;}
        
        string Key { get; set;}
        
        List<IStoreKeyReference> Stores { get; set;}
    }
}
