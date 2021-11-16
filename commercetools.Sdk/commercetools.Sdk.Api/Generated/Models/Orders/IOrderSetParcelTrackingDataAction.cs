using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetParcelTrackingDataAction))]
    public partial interface IOrderSetParcelTrackingDataAction : IOrderUpdateAction
    {
        string ParcelId { get; set;}
        
        ITrackingData TrackingData { get; set;}
    }
}
