using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Stores;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyCustomerDraft 
    {
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
        
        long DefaultShippingAddress { get; set;}
        
        long DefaultBillingAddress { get; set;}
        
        ICustomFields Custom { get; set;}
        
        string Locale { get; set;}
        
        List<IStoreResourceIdentifier> Stores { get; set;}
    }
}
