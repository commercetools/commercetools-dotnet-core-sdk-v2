using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    public class ApiClientDraft 
    {
        public string Name { get; set;}
        
        public string Scope { get; set;}
        
        public long DeleteDaysAfterCreation { get; set;}
    }
}
