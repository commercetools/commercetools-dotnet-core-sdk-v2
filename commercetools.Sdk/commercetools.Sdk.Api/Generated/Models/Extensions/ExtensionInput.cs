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
        public string Action { get; set;}
        
        [JsonIgnore]
        public ExtensionAction ActionAsEnum => this.Action.GetEnum<ExtensionAction>();
        
        public IReference Resource { get; set;}
    }
}
