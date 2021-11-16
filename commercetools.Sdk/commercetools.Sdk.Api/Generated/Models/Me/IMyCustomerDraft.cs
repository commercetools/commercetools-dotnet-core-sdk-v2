using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCustomerDraft))]
    public partial interface IMyCustomerDraft 
    {
        string Email { get; set;}
        
        string Password { get; set;}
        
        string FirstName { get; set;}
        
        string LastName { get; set;}
        
        string MiddleName { get; set;}
        
        string Title { get; set;}
        
        DateTime? DateOfBirth { get; set;}
        
        string CompanyName { get; set;}
        
        string VatId { get; set;}
        
        List<IBaseAddress> Addresses { get; set;}
        
        long? DefaultShippingAddress { get; set;}
        
        long? DefaultBillingAddress { get; set;}
        
        ICustomFields Custom { get; set;}
        
        string Locale { get; set;}
        
        List<IStoreResourceIdentifier> Stores { get; set;}
    }
}
