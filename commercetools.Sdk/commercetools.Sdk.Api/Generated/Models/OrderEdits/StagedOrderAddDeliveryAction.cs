using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddDeliveryAction : IStagedOrderAddDeliveryAction
    {
        public string Action { get; set; }

        public List<IDeliveryItem> Items { get; set; }

        public IBaseAddress Address { get; set; }

        public List<IParcelDraft> Parcels { get; set; }
        public StagedOrderAddDeliveryAction()
        {
            this.Action = "addDelivery";
        }
    }
}
