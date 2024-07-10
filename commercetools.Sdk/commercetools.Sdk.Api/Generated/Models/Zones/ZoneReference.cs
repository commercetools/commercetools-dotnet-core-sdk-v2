using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneReference : IZoneReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IZone Obj { get; set; }
        public ZoneReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("zone");
        }
    }
}
