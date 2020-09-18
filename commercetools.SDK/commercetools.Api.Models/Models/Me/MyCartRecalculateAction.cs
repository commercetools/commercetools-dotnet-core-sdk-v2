using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("recalculate")]
    public class MyCartRecalculateAction : MyCartUpdateAction
    {
        public bool UpdateProductData { get; set;}
    }
}
