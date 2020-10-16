using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("changeDestination")]
    public partial class ExtensionChangeDestinationAction : ExtensionUpdateAction
    {
        public ExtensionDestination Destination { get; set;}
        public ExtensionChangeDestinationAction()
        { 
           this.Action = "changeDestination";
        }
    }
}
