using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.RemoveParcelFromDeliveryDraft))]
    public partial interface IRemoveParcelFromDeliveryDraft 
    {
        string ParcelId { get; set;}
    }
}
