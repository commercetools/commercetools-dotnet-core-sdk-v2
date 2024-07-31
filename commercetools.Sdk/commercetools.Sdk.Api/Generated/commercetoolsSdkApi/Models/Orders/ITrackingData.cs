using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.TrackingData))]
    public partial interface ITrackingData
    {
        string TrackingId { get; set; }

        string Carrier { get; set; }

        string Provider { get; set; }

        string ProviderTransaction { get; set; }

        bool? IsReturn { get; set; }

    }
}
