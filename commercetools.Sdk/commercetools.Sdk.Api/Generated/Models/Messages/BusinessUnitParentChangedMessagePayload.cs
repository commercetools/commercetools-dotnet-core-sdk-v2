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

    public partial class BusinessUnitParentChangedMessagePayload : IBusinessUnitParentChangedMessagePayload
    {
        public string Type { get; set; }

        public IBusinessUnitKeyReference OldParentUnit { get; set; }

        public IBusinessUnitKeyReference NewParentUnit { get; set; }
        public BusinessUnitParentChangedMessagePayload()
        {
            this.Type = "BusinessUnitParentChanged";
        }
    }
}
