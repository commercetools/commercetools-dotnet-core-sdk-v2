using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class BusinessUnitCreatedMessagePayload : IBusinessUnitCreatedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnit BusinessUnit { get; set; }
        public BusinessUnitCreatedMessagePayload()
        {
            this.Type = "BusinessUnitCreated";
        }
    }
}
