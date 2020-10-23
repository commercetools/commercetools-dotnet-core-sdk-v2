using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ApiClients
{
    public  partial class ApiClientDraft : IApiClientDraft
    {
        public string Name { get; set;}
        
        public string Scope { get; set;}
        
        public long DeleteDaysAfterCreation { get; set;}
    }
}
