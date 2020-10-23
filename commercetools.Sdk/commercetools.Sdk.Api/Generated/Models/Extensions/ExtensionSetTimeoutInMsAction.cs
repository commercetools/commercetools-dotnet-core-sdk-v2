using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public  partial class ExtensionSetTimeoutInMsAction : IExtensionSetTimeoutInMsAction
    {
        public string Action { get; set;}
        
        public int TimeoutInMs { get; set;}
        public ExtensionSetTimeoutInMsAction()
        { 
           this.Action = "setTimeoutInMs";
        }
    }
}
