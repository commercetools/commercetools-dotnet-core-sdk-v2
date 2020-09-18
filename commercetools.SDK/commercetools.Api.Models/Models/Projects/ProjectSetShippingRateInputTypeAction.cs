using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("setShippingRateInputType")]
    public class ProjectSetShippingRateInputTypeAction : ProjectUpdateAction
    {
        public ShippingRateInputType ShippingRateInputType { get; set;}
    }
}
