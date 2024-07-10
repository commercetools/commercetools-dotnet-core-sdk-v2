using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddAddressAction : IBusinessUnitAddAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public BusinessUnitAddAddressAction()
        {
            this.Action = "addAddress";
        }
    }
}
