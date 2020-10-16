using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("changeTriggers")]
    public partial class ExtensionChangeTriggersAction : ExtensionUpdateAction
    {
        public List<ExtensionTrigger> Triggers { get; set;}
        public ExtensionChangeTriggersAction()
        { 
           this.Action = "changeTriggers";
        }
    }
}
