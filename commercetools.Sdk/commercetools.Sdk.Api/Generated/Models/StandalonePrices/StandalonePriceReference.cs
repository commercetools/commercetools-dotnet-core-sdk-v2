using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceReference : IStandalonePriceReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IStandalonePrice Obj { get; set; }
        public StandalonePriceReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("standalone-price");
        }
    }
}
