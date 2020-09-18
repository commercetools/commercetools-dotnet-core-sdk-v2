using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("changeTriggers")]
    public class ExtensionChangeTriggersAction : ExtensionUpdateAction
    {
        public List<ExtensionTrigger> Triggers { get; set;}
    }
}
