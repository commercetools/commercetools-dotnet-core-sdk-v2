using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerCompanyNameSetMessagePayload : ICustomerCompanyNameSetMessagePayload
    {
        public string Type { get; set; }

        public string CompanyName { get; set; }
        public CustomerCompanyNameSetMessagePayload()
        {
            this.Type = "CustomerCompanyNameSet";
        }
    }
}
