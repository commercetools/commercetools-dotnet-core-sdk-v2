using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditReference : IOrderEditReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IOrderEdit Obj { get; set; }
        public OrderEditReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order-edit");
        }
    }
}
