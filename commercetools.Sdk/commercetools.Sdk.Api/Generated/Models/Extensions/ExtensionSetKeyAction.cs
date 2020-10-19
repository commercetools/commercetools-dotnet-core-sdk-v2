using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("setKey")]
    public partial class ExtensionSetKeyAction : ExtensionUpdateAction
    {
        public string Key { get; set;}
        public ExtensionSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
