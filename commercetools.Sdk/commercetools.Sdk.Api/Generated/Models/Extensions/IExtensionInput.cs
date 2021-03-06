using commercetools.Api.Models.Common;
using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionInput))]
    public partial interface IExtensionInput 
    {
        IExtensionAction Action { get; set;}
        
        IReference Resource { get; set;}
    }
}
