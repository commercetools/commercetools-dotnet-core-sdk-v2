using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerCustomTypeSetMessagePayload : ICustomerCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string PreviousTypeId { get; set; }
        public CustomerCustomTypeSetMessagePayload()
        {
            this.Type = "CustomerCustomTypeSet";
        }
    }
}
