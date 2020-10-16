using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Messages
{
    public partial class UserProvidedIdentifiers 
    {
        public string Key { get; set;}
        
        public string ExternalId { get; set;}
        
        public string OrderNumber { get; set;}
        
        public string CustomerNumber { get; set;}
        
        public string Sku { get; set;}
        
        public LocalizedString Slug { get; set;}
    }
}
