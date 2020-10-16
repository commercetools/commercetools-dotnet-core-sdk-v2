using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionTrigger 
    {
        public string ResourceTypeId { get; set;}
        
        [JsonIgnore]
        public ExtensionResourceTypeId ResourceTypeIdAsEnum => this.ResourceTypeId.GetEnum<ExtensionResourceTypeId>();
        
        public List<string> Actions { get; set;}
        
        [JsonIgnore]
        public List<ExtensionAction> ActionsAsEnum => this.Actions.GetEnum<ExtensionAction>();
    }
}
