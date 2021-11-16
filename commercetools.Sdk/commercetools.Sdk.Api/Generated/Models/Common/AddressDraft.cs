using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class AddressDraft : IAddressDraft
    {
        public string Id { get; set;}
        
        public string Key { get; set;}
        
        public string Title { get; set;}
        
        public string Salutation { get; set;}
        
        public string FirstName { get; set;}
        
        public string LastName { get; set;}
        
        public string StreetName { get; set;}
        
        public string StreetNumber { get; set;}
        
        public string AdditionalStreetInfo { get; set;}
        
        public string PostalCode { get; set;}
        
        public string City { get; set;}
        
        public string Region { get; set;}
        
        public string State { get; set;}
        
        public string Country { get; set;}
        
        public string Company { get; set;}
        
        public string Department { get; set;}
        
        public string Building { get; set;}
        
        public string Apartment { get; set;}
        
        public string POBox { get; set;}
        
        public string Phone { get; set;}
        
        public string Mobile { get; set;}
        
        public string Email { get; set;}
        
        public string Fax { get; set;}
        
        public string AdditionalAddressInfo { get; set;}
        
        public string ExternalId { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
    }
}
