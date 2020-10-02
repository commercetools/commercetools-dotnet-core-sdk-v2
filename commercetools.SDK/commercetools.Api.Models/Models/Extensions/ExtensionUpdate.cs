using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionUpdate 
    {
        public long Version { get; set;}
        
        public List<ExtensionUpdateAction> Actions { get; set;}
    }
}
