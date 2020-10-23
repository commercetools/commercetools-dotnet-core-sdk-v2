using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    public  partial class ExtensionChangeDestinationAction : IExtensionChangeDestinationAction
    {
        public string Action { get; set;}
        
        public IExtensionDestination Destination { get; set;}
        public ExtensionChangeDestinationAction()
        { 
           this.Action = "changeDestination";
        }
    }
}
