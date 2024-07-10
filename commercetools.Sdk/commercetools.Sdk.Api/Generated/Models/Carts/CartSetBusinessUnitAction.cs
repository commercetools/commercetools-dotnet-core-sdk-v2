using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetBusinessUnitAction : ICartSetBusinessUnitAction
    {
        public string Action { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }
        public CartSetBusinessUnitAction()
        {
            this.Action = "setBusinessUnit";
        }
    }
}
