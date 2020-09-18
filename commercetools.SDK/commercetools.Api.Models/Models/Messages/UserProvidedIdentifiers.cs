using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public class UserProvidedIdentifiers 
    {
        public string Key { get; set;}
        
        public string ExternalId { get; set;}
        
        public string OrderNumber { get; set;}
        
        public string CustomerNumber { get; set;}
        
        public string Sku { get; set;}
        
        public LocalizedString Slug { get; set;}
    }
}
