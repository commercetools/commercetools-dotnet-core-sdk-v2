using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.DeliveryDraft))]
    public partial interface IDeliveryDraft
    {
        List<IDeliveryItem> Items { get; set; }

        IAddress Address { get; set; }

        List<IDeliveryParcelDraft> Parcels { get; set; }

    }
}
