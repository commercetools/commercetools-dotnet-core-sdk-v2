using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    public class ExtensionUpdate 
    {
        public long Version { get; set;}
        
        public List<ExtensionUpdateAction> Actions { get; set;}
    }
}
