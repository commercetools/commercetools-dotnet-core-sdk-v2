using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitReference : IBusinessUnitReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IBusinessUnit Obj { get; set; }
        public BusinessUnitReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("business-unit");
        }
    }
}
