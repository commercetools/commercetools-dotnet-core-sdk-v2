using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetReturnShipmentStateAction : IStagedOrderSetReturnShipmentStateAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public string ReturnItemKey { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }
        public StagedOrderSetReturnShipmentStateAction()
        {
            this.Action = "setReturnShipmentState";
        }
    }
}
