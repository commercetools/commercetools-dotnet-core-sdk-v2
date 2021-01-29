using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customers
{
    public partial class CustomerImport : ICustomerImport
    {
        public string Key { get; set;}
        
        public string CustomerNumber { get; set;}
        
        public string Email { get; set;}
        
        public string Password { get; set;}
        
        public string FirstName { get; set;}
        
        public string LastName { get; set;}
        
        public string MiddleName { get; set;}
        
        public string Title { get; set;}
        
        public string Salutation { get; set;}
        
        public string ExternalId { get; set;}
        
        public DateTime DateOfBirth { get; set;}
        
        public string CompanyName { get; set;}
        
        public string VatId { get; set;}
        
        public bool? IsEmailVerified { get; set;}
        
        public ICustomerGroupKeyReference CustomerGroup { get; set;}
        
        public List<IAddress> Addresses { get; set;}
        
        public IAddress DefaultBillingAddress { get; set;}
        
        public IAddress BillingAddresses { get; set;}
        
        public IAddress DefaultShippingAddress { get; set;}
        
        public IAddress ShippingAddresses { get; set;}
        
        public string Locale { get; set;}
        
        public ICustom Custom { get; set;}
    }
}
