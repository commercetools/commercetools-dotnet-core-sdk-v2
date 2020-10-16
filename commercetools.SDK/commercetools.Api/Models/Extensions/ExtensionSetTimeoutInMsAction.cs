using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("setTimeoutInMs")]
    public partial class ExtensionSetTimeoutInMsAction : ExtensionUpdateAction
    {
        public int TimeoutInMs { get; set;}
        public ExtensionSetTimeoutInMsAction()
        { 
           this.Action = "setTimeoutInMs";
        }
    }
}
