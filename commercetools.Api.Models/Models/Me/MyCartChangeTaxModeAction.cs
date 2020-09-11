using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCartChangeTaxModeAction : MyCartUpdateAction
    {
        public TaxMode TaxMode { get; set;}
    }
}
