using commercetools.Api.Models.Common;
using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Extensions
{
    public class ExtensionInput 
    {
        public ExtensionAction Action { get; set;}
        
        public Reference Resource { get; set;}
    }
}
