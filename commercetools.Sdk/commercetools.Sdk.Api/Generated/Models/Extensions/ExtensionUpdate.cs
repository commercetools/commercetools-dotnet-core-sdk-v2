using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public  partial class ExtensionUpdate : IExtensionUpdate
    {
        public long Version { get; set;}
        
        public List<IExtensionUpdateAction> Actions { get; set;}
    }
}
