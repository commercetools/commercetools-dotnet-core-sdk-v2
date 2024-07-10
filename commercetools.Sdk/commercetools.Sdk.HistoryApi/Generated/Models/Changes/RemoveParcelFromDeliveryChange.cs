using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveParcelFromDeliveryChange : IRemoveParcelFromDeliveryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IParcel PreviousValue { get; set; }

        public string DeliveryId { get; set; }
        public RemoveParcelFromDeliveryChange()
        {
            this.Type = "RemoveParcelFromDeliveryChange";
        }
    }
}
