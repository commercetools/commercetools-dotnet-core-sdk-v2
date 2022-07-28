using commercetools.Sdk.ImportApi.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ParcelTrackingData))]
    public partial interface IParcelTrackingData
    {
        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }

    }
}
