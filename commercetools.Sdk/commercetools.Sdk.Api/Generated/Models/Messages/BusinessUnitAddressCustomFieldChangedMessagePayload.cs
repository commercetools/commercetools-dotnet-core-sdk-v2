using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitAddressCustomFieldChangedMessagePayload : IBusinessUnitAddressCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object OldValue { get; set; }

        public string AddressId { get; set; }
        public BusinessUnitAddressCustomFieldChangedMessagePayload()
        {
            this.Type = "BusinessUnitAddressCustomFieldChanged";
        }
    }
}
