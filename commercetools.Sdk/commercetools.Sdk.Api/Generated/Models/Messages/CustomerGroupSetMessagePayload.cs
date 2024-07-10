using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupSetMessagePayload : ICustomerGroupSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }
        public CustomerGroupSetMessagePayload()
        {
            this.Type = "CustomerGroupSet";
        }
    }
}
