using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Reservation))]
    public partial interface IReservation
    {
        int Quantity { get; set; }

        IReference Owner { get; set; }

        string CreatedAt { get; set; }

        string CheckoutStartedAt { get; set; }

    }
}
