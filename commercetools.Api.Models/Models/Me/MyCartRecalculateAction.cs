using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCartRecalculateAction : MyCartUpdateAction
    {
        public bool UpdateProductData { get; set;}
    }
}
