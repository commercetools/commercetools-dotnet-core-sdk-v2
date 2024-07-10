using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitBillingAddressRemovedMessagePayload : IBusinessUnitBillingAddressRemovedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public BusinessUnitBillingAddressRemovedMessagePayload()
        {
            this.Type = "BusinessUnitBillingAddressRemoved";
        }
    }
}
