using commercetools.ImportApi.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.ParcelTrackingData))]
    public partial interface IParcelTrackingData 
    {
        string ParcelId { get; set;}
        
        ITrackingData TrackingData { get; set;}
    }
}
