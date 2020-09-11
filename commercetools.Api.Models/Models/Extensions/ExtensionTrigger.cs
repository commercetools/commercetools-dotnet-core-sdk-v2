using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    public class ExtensionTrigger 
    {
        public ExtensionResourceTypeId ResourceTypeId { get; set;}
        
        public List<ExtensionAction> Actions { get; set;}
    }
}
