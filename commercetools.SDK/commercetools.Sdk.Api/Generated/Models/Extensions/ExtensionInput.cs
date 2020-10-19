using commercetools.Api.Models.Common;
using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionInput 
    {
        public string Action { get; set;}
        
        [JsonIgnore]
        public ExtensionAction ActionAsEnum => this.Action.GetEnum<ExtensionAction>();
        
        public Reference Resource { get; set;}
    }
}
