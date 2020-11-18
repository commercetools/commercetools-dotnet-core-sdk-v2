using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionTrigger : IExtensionTrigger
    {
        public IExtensionResourceTypeId ResourceTypeId { get; set;}
        
        public List<IExtensionAction> Actions { get; set;}
    }
}
