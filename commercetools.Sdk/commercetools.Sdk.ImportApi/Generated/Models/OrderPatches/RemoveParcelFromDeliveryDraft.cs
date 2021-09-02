using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class RemoveParcelFromDeliveryDraft : IRemoveParcelFromDeliveryDraft
    {
        public string ParcelId { get; set; }
    }
}
