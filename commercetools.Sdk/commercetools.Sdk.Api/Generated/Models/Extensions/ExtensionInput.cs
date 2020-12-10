using commercetools.Api.Models.Common;
using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionInput : IExtensionInput
    {
        public IExtensionAction Action { get; set;}
        
        public IReference Resource { get; set;}
    }
}
