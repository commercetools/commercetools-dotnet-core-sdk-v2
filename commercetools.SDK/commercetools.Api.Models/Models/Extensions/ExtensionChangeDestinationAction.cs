using commercetools.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DiscriminatorValue("changeDestination")]
    public class ExtensionChangeDestinationAction : ExtensionUpdateAction
    {
        public ExtensionDestination Destination { get; set;}
    }
}
