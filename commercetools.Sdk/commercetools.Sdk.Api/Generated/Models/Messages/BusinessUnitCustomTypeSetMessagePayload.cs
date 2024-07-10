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

    public partial class BusinessUnitCustomTypeSetMessagePayload : IBusinessUnitCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string OldTypeId { get; set; }
        public BusinessUnitCustomTypeSetMessagePayload()
        {
            this.Type = "BusinessUnitCustomTypeSet";
        }
    }
}
