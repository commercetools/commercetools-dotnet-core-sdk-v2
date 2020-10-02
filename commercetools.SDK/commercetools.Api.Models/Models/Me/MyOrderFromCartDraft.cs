using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyOrderFromCartDraft 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
    }
}
