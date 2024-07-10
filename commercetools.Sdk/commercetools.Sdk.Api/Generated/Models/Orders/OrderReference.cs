using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderReference : IOrderReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IOrder Obj { get; set; }
        public OrderReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("order");
        }
    }
}
