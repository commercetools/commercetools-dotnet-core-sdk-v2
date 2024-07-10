using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressCustomTypeRemovedMessagePayload : ICustomerAddressCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PreviousTypeId { get; set; }

        public string AddressId { get; set; }
        public CustomerAddressCustomTypeRemovedMessagePayload()
        {
            this.Type = "CustomerAddressCustomTypeRemoved";
        }
    }
}
