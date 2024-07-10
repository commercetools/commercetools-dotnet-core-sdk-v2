using commercetools.Sdk.Api.Models.BusinessUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddShippingAddressIdAction : IBusinessUnitAddShippingAddressIdAction
    {
        public string Action { get; set; }

        public string AddressId { get; set; }

        public string AddressKey { get; set; }
        public BusinessUnitAddShippingAddressIdAction()
        {
            this.Action = "addShippingAddressId";
        }
    }
}
