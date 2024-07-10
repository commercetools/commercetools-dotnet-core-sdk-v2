using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetDeliveryCustomTypeAction : IStagedOrderSetDeliveryCustomTypeAction
    {
        public string Action { get; set; }

        public string DeliveryId { get; set; }

        public string DeliveryKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetDeliveryCustomTypeAction()
        {
            this.Action = "setDeliveryCustomType";
        }
    }
}
